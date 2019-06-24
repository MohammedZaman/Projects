<?php

session_start();
$ID1 = $_SESSION["id"];
$ID = str_replace(array('[', ']'), '', $ID1);
$delError = "";

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

if (isset($_POST['Delete'])) {
    if(!empty($_POST['check_list'])) {
    foreach($_POST['check_list'] as $check) {
           $sql = "DELETE FROM images WHERE id = '$check' ";
           $posts = $conn->query($sql);
        $delError = "Items deleted";
         header('Location: ' . "MyPosts.php");
    }
    }else{
     $delError = "Select Images to delete";
    }
    
}

?>