<?php

$servername = "mysql:3306";
$username = "mz7340g";
$password = "Tanveer1";
$dbname = "mdb_mz7340g";

 $notify = "";


// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
session_start();
// Store Session Data
$myusername = $_SESSION['login_user'];


$sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql);
$verify = mysqli_fetch_assoc($verified);
if ($verify['Verified'] == 1) {
    header('Location: ' . "index.php");
}elseif($myusername == null){
    header('Location: ' . "index.php");
}
if (isset($_POST['verify'])) {
    $verifyErr = "";
    if ($_POST['VerifCode'] == "") {
        $notify = "*";
    }elseif (!preg_match('/^[0-9]*$/', $_POST['VerifCode'])) {
        $notify =  "<br><p style='color:red'>This field except Numbers only</p>";
    } else {

        $servername = "mysql:3306";
        $username = "mz7340g";
        $password = "Tanveer1";
        $dbname = "mdb_mz7340g";



// Create connection
        $conn = new mysqli($servername, $username, $password, $dbname);
        session_start();
        // Store Session Data
        $myusername = $_SESSION['login_user'];


        $sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
        $verified = $conn->query($sql);
        $verify = mysqli_fetch_assoc($verified);
        if ($verify['VerifcationCode'] == $_POST['VerifCode']) {
            $inactive = true;
            $balance = 100;
            //insert results from the form input
            $query = "UPDATE Users SET Balance = '" . $balance . "',Verified = " . ($inactive ? 1 : 0) . " WHERE UserName = '" . $myusername . "'";

            $result = mysqli_query($conn, $query) or die('Error querying database.');
            header('Location: ' . "index.php");
        } else {
            $notify = "Incorrect code ";
        }
    }
}
?>      