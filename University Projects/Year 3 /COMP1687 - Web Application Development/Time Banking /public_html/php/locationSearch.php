<?php
$suggested ="";
$error = "";
session_start();
$myusername = $_SESSION['login_user'];
$lat =$_POST['latitude'];
        $long = $_POST['longitude'];
        $location = $lat.','.$long;
        $taskloc = $post['TaskLocation'];

$sql = "";
$style="display:none;";
$result_count ="";



 


/*// suggested posts based on user's skill set
$sqlSkill = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$skills = $conn->query($sqlSkill);
$skill = mysqli_fetch_assoc($skills);
$sqlForSkill = "SELECT * FROM Posts WHERE SkillsReq LIKE '%" . $skill['Skills']. "%' LIMIT 25"; 
$skillcheck = $conn->query($sqlForSkill);
$checkrows = mysqli_num_rows($skillcheck);
if($checkrows == 0){
$sql = "SELECT * FROM Posts";  
$posts = $conn->query($sql);
$suggested ="";
}*/
/* interfering with the pagernation
if($myusername == null){
$sql = "SELECT * FROM Posts";  
$posts = $conn->query($sql);
$suggested ="";  
}else{
$sqlSkill = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$skills = $conn->query($sqlSkill);
$skill = mysqli_fetch_assoc($skills);
$sql = "SELECT * FROM Posts WHERE SkillsReq LIKE '%" . $skill['Skills']. "%' LIMIT 25"; 
$posts = $conn->query($sql);
$suggested ="&#9733; Suggested Post &#9733;";
}
*/

 
    

if (isset($_GET['page_no']) && $_GET['page_no']!="") {
    $page_no = $_GET['page_no'];
    } else {
        $page_no = 1;
        }
$page_no = 1;
$total_records_per_page = 5;
$offset = ($page_no-1) * $total_records_per_page;
$previous_page = $page_no - 1;
$next_page = $page_no + 1;
$adjacents = "2";

$second_last = $total_no_of_pages - 1;  




/*
$sqlSkill1 = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$skills1 = $conn->query($sqlSkill1);
$skill1 = mysqli_fetch_assoc($skills1);
$sqlcheck = "SELECT * FROM Posts WHERE SkillsReq LIKE '%" . $skill1['Skills']. "%' LIMIT 25"; 



 $checkrows = mysqli_num_rows($sqlcheck);
if ($checkrows > 0) {
$sqlSkill = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$skills = $conn->query($sqlSkill);
$skill = mysqli_fetch_assoc($skills);
$sql = "SELECT * FROM Posts WHERE SkillsReq LIKE '%" . $skill['Skills']. "%' LIMIT 25"; 
$posts = $conn->query($sql);  
}else{
$sql = "SELECT * FROM Posts";
$posts = $conn->query($sql);
}
*/

// redirect if not verifed after logged in
$sql1 = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql1);
$verify = mysqli_fetch_assoc($verified);
if ($verify['Verified'] == 0 && $myusername != null ) {
    header('Location: ' . "Verify.php");
} 



if (isset($_POST['button'])) {
$sql = "SELECT * FROM Posts LIMIT $offset, $total_records_per_page";
$posts = $conn->query($sql);   
 $result_count = mysqli_query(
$conn,
"SELECT COUNT(*) As total_records FROM `Posts`"
);
$total_records = mysqli_fetch_array($result_count);
$total_records = $total_records['total_records'];
$total_no_of_pages = ceil($total_records / $total_records_per_page);
$style="display:block;";
}



?>