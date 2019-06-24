<?php

session_start();
// Store Session Data
$myusername = $_SESSION['login_user'];


$sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql);
$verify = mysqli_fetch_assoc($verified);
if ($verify['Verified'] == 0) {
    header('Location: ' . "Verify.php");
} elseif ($myusername == null) {
    header('Location: ' . "index.php");
}
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    
}
if (isset($_POST['addPost'])) {
    $tasktypeErr = "";
    $skillReqErr = "";
    $taskLocErr = "";
    $creditErr = "";
    $StatusErr = "";
    $notify = "";
    

    if (empty($_POST['taskType'])) {
        $tasktypeErr = "*";
    }if (empty($_POST['skillsReq'])) {
        $skillReqErr = "*";
    }if (empty($_POST['taskLoc'])) {
        $taskLocErr = "*";
    }
    
    if (empty($_POST['credit'])) {
        $creditErr = "*";
    }elseif (!preg_match('/^[0-9]*$/', $_POST['credit'])) {
        $creditErr = "<br><p style='color:red'>This field except Whole numbers only</p>";
    }

    else {

        $myusername = $_SESSION['login_user'];
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

        //Prepared statement prevents SQL Injections           

        $stmt = $conn->prepare("INSERT IGNORE INTO Posts(TaskType,SkillsReq, TaskLocation,CreditAwarded,Status,AddedBy)
     VALUES (?,?,?,?,?,?)");
        $stmt->bind_param("sssiis", $taskType, $SkillsReq, $TaskLocation, $creditAwarded, $statusCheck, $myusername);

// set parameters and execute
        $stmt->execute();
        $stmt->close();
        $conn->close();


        /*
          old Code
          $query = "INSERT IGNORE INTO Posts(TaskType,SkillsReq, TaskLocation,CreditAwarded,Status,AddedBy)
          VALUES ('" . $taskType. "','" .$SkillsReq. "','" .  $TaskLocation . "','" . $creditAwarded . "'," . ($status ? 1 : 0) . ",'" . $myusername . "')";

          $result = mysqli_query($conn, $query) or die('Error querying database.');

          mysqli_close($conn); */

        $notify = "your Post has been uplaoded";

        header('Location: ' . "MyPosts.php");
    }
}
?>