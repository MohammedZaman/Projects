<?php

session_start();
$ID1 = $_SESSION["id"];
$ID = str_replace(array('[', ']'), '', $ID1);

// redirect for if user is not signed or not verified
$myusername = $_SESSION['login_user'];
$sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql);
$verify = mysqli_fetch_assoc($verified);
if ($verify['Verified'] == 0) {
    header('Location: ' . "Verify.php");
} elseif ($myusername == null) {
    header('Location: ' . "index.php");
}

$sql = "SELECT * FROM Posts WHERE PostID = '$ID' ";
$posts = $conn->query($sql);
if (isset($_POST['update'])) {
    $tasktypeErr = "";
    $skillReqErr = "";
    $taskLocErr = "";
    $creditErr = "";
    $StatusErr = "";
    $notify = "";

    if ($_POST['taskType'] == "") {
        $tasktypeErr = "*";
    }if ($_POST['skillsReq'] == "") {
        $skillReqErr = "*";
    }if ($_POST['taskLoc'] == "") {
        $taskLocErr = "*";
    }if ($_POST['credit'] == "") {
        $creditErr = "*";
    } else {
        $servername = "mysql:3306";
        $username = "mz7340g";
        $password = "Tanveer1";
        $dbname = "mdb_mz7340g";



// Create connection
        $conn = new mysqli($servername, $username, $password, $dbname);
        $myusername = $_POST['UserName'];
        $password = ($_POST['Password']);
        $taskType = $_POST['taskType'];
        $SkillsReq = $_POST['skillsReq'];
        $TaskLocation = $_POST['taskLoc'];
        $creditAwarded = $_POST['credit'];
        $statusCheck = $_POST['status'];
        $status = false;
        if ($statusCheck == 0) {
            $status = false;
        } elseif ($statusCheck == 1) {
            $status = true;
        }

         $updatedNum = $_POST['update'];

          $stmt = $conn->prepare("UPDATE Posts SET TaskType= ?, SkillsReq=?,TaskLocation=?, CreditAwarded =?, Status=? WHERE PostID= ?");
          $stmt->bind_param("sssiii",$taskType,$SkillsReq,$TaskLocation,$creditAwarded, $status,$updatedNum);

          $stmt->execute();
          $stmt->close();
          $conn->close();
        
    

        header('Location: ' . "MyPosts.php");
        $notify = "your Post has been uplaoded";
    }
}
?>