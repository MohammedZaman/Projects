<?php
session_start();
if ($_SESSION['login_user'] != null) {
 header('Location: ' . "index.php");    
}
//get the name and comment entered by user
if (isset($_POST['logIn'])) {
    $userNameErr = "";
    $userPasswordErr = "";
    $error = "";

    if ($_POST['UserName'] == "") {
        $userNameErr = "*";
    }
    if ($_POST['Password'] == "") {
        $userPasswordErr = "*";
    } else {
    
        $myusername = $_POST['UserName'];
        $password = ($_POST['Password']);
        $passwordhash = sha1($password);
        /* old Code
        $check = mysqli_query($conn, "select * from Users where UserName='$myusername' and Password = '$passwordhash' ");
        $checkrows = mysqli_num_rows($check);*/
        $stmt = $conn->prepare("select * from Users where UserName= ? and Password = ? ");
        $stmt->bind_param("ss",$myusername,$passwordhash );
        $stmt->execute();
        $stmt->store_result();
        // check if uname and pword correct on the db
        if ($stmt->num_rows == 1) {
            $cookie_name = "userName";
            $cookie_value = $_POST['UserName'];
            setcookie($cookie_name, $cookie_value, time()  + (10 * 365 * 24 * 60 * 60)); // 315360000 = 10 years        
            session_start();
            // Store Session Data
            $_SESSION['login_user'] = $myusername;
            header('Location: ' . "index.php");
       
            $sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
            $verified = $conn->query($sql);
            $verify = mysqli_fetch_assoc($verified);
            //session_regenerate_id();
        if ($verify['Verified'] == 0) {
        header('Location: ' . "Verify.php");
        }
        } 
        else {
            $error = "Invalid Username Or Password";
        }
        $stmt->close();
        $conn->close();
    }
}
?>