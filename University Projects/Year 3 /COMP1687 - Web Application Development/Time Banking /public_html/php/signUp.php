
<?php
session_start();
if ($_SESSION['login_user'] != null) {
 header('Location: ' . "index.php");    
}

if (isset($_POST['button'])) {
    session_start();
    $notify ="";
    $userNameErr = "";
    $userPasswordErr = "";
    $userEmailErr = "";
    $userSkillsErr = "";
    $captchaErr= "";
    session_start();
    if ($_POST['UserName'] == "") {
        $userNameErr = "*";
    }
    if ($_POST['Password'] == "") {
        $userPasswordErr = "*";
    }
    if ($_POST['Email'] == "") {
        $userEmailErr = "*";
    }
    if ($_POST['Skills'] == "") {
        $userSkillsErr = "*";
    }
    if ($_POST['Skills'] == "") {
        $captchaErr = "*";
    }elseif($_POST['captcha'] != $_SESSION['code']){
    $notify = "Invalid Captcha";    
    }
    else{
    
        //get the name and comment entered by user
        $UserName = $_POST['UserName'];
        $notify = "";


        $check = mysqli_query($conn, "select * from Users where UserName='$UserName'");
        $checkrows = mysqli_num_rows($check);


        if ($checkrows > 0) {
            $notify = "<p> User Name exists please pick another <p>";
        } else {
            $myusername = $_POST['UserName'];
            $password = ($_POST['Password']);
            $passwordhash = sha1($password);
           
            // data to be added to db
            $uname  = $_POST["UserName"];
            $email = $_POST["Email"];
            $skills = $_POST["Skills"];
            $random = rand(10000, 99999);
            $inactive = false;
            $inactiveNum = $inactive ? 1 : 0;
            
            $stmt = $conn->prepare("INSERT IGNORE INTO Users (UserName, Password, Email,Skills,VerifcationCode,Verified)
            VALUES (?,?,?,?,?,?)");
            $stmt->bind_param("ssssii", $uname,$passwordhash,$email,$skills,$random, $inactiveNum);

// set parameters and execute
             $stmt->execute();
             $stmt->close();
             $conn->close();
            
           /* $query = "INSERT IGNORE INTO Users (UserName, Password, Email,Skills,VerifcationCode,Verified)
            VALUES ('" . $_POST["UserName"] . "','" . $passwordhash. "','" . $_POST["Email"] . "','" . $_POST["Skills"] . "','" . $random . "'," . ($inactive ? 1 : 0) . ")";

            $result = mysqli_query($conn, $query) or die('Error querying database.');

            mysqli_close($conn);
*/
            $to = $_POST["Email"];
            $subject = 'verify';
            $message = 'Verifcation Code:' + $random;
            $headers = 'From: mz7340g@gre.ac.uk' . "\r\n" .
                    'Reply-To: webmaster@example.com' . "\r\n" .
                    'X-Mailer: PHP/' . phpversion();

            mail($to, $subject, $message, $headers);
            
            $notify = "<p> Your account has been created <p>";
            //session_regenerate_id();
            
             session_start();
            // Store Session Data
            $_SESSION['login_user'] = $myusername;
            header('Location: '."Verify.php");
        }
    }
};
?>
