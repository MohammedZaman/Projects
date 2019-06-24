<?php
$suggested ="";
$error = "";
session_start();
$myusername = $_SESSION['login_user'];
$posts ="";
$sql = "";
$style="";
$param1Err = "";
$param2Err="";
$style ="display:none;";
$op1 ="";
$param1="";


$result_count ="";
if (isset($_GET['page_no']) && $_GET['page_no']!="") {
    $page_no = $_GET['page_no'];
    } else {
        $page_no = 1;
        }

$total_records_per_page = 5;
$offset = ($page_no-1) * $total_records_per_page;
$previous_page = $page_no - 1;
$next_page = $page_no + 1;
$adjacents = "2";



// suggested posts based on user's skill set
/*$sqlSkill = "SELECT * FROM Users WHERE UserName = '$myusername' ";
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

 
    


    



 
// redirect if not verifed after logged in
$sql1 = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql1);
$verify = mysqli_fetch_assoc($verified);
if ($verify['Verified'] == 0 && $myusername != null ) {
    header('Location: ' . "Verify.php");
} 




if (isset($_POST['button'])) {
$op1 = $_POST['op1'];
$op2 = $_POST['op2'];
$param1 = mysqli_real_escape_string($conn,$_POST['param1']);
$param2 = mysqli_real_escape_string($conn,$_POST['param2']);
if (isset($_GET['page_no']) && $_GET['page_no']!="") {
    $page_no = $_GET['page_no'];
    } else {
        $page_no = 1;
        }
if($op1 == $op2){
    $error = "the types cannot be the same";
}
if($param1 =="" ||$param2 =="" ){
$param1Err = "*";
$param2Err = "*";
}else{
    $result_count = mysqli_query(
$conn,  
"SELECT COUNT(*) As total_records FROM Posts WHERE $op1 LIKE '%" .$param1 . "%' AND $op2 LIKE '%" .$param2 . "%'");
$total_records = mysqli_fetch_array($result_count);
$total_records = $total_records['total_records'];
$total_no_of_pages = ceil($total_records / $total_records_per_page);
$offset = ($page_no-1) * $total_records_per_page;
$second_last = $total_no_of_pages - 1; 
$style ="display:block;";  
$sql = "SELECT * FROM Posts WHERE $op1 LIKE '%" .$param1 . "%' AND $op2 LIKE '%" .$param2 . "%' LIMIT $offset, $total_records_per_page";
$posts = $conn->query($sql); 

}
}


?>