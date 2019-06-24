<?php

session_start();
$myusername = $_SESSION['login_user'];
$sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql);
$verify = mysqli_fetch_assoc($verified);
if ($verify['Verified'] == 0) {
    header('Location: ' . "Verify.php");
} elseif ($myusername == null) {
    header('Location: ' . "index.php");
}

$sql = "SELECT * FROM Posts WHERE AddedBy = '$myusername' ";
$posts = $conn->query($sql);
session_start();
if (isset($_POST['id'])) {
    $_SESSION["id"] = $_POST['id'];
    header('Location: ' . "EditPost.php");
} elseif (isset($_POST['del'])) {
    $_SESSION["id"] = $_POST['del'];
    $ID1 = $_SESSION["id"];
    $ID = str_replace(array('[', ']'), '', $ID1);
    $sql = "DELETE FROM Posts WHERE PostID = '$ID' ";
    $posts = $conn->query($sql);
    $sql = "DELETE FROM images WHERE PostID = '$ID' ";
    $posts = $conn->query($sql);
    header('Location: ' . "MyPosts.php");
} elseif (isset($_POST['uploadImg'])) {
    $_SESSION["id"] = $_POST['uploadImg'];
    header('Location: ' . "UploadImg.php");
} elseif(isset($_POST['deleteImg'])){
        $ID = $_POST['deleteImg'];
        $_SESSION["id"] = $_POST['deleteImg'];
        header('Location: ' . "DeleteImg.php");

}
?>