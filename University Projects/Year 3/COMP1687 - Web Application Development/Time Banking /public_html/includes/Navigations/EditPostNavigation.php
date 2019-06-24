<?php  
$bal;
$uName;
$style = "";
$hiddenStyle = "display:block;";
session_start();
if($_SESSION['login_user'] != ""){
    $uName = $_SESSION['login_user'];
    $style='display:inline-block';
   $hiddenStyle = 'display:none !important;';
}else{
    $style='display:none !important';
    $hiddenStyle = 'display:inline-block';
    $uName = "";
}
$servername = "mysql:3306";
$username = "mz7340g";
$password = "Tanveer1";
$dbname = "mdb_mz7340g";



// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
session_start();
// Store Session Data


if($_SESSION['login_user'] != null){
$myusername = $_SESSION['login_user'];    
$sql = "SELECT * FROM Users WHERE UserName = '$myusername' ";
$verified = $conn->query($sql);
$verify = mysqli_fetch_assoc($verified);
$bal =  $verify['Balance'];
}
?>
<div class="logo"> <h1> TimeBanking </h1></div>

<div class="nav">
  	
	<div class=" navbar"><li><a  class="icon" id="clickme" onclick="myFunction()">
    <i class="fa fa-bars"></i>
  </a> 	</li></div> 
    <ul id="menu" >
        <li class="noHover"><a href='#'><?php echo $uName ?></a></li>
        <li class="noHover"><a href='#'><?php echo $bal ;  ?></a></li>
        <li><a href="index.php">Home</a></li>
        <li><a href="ViewPost.php">View Posts</a></li>
        <li style="<?php echo $hiddenStyle ?>"><a href="register.php">Sign Up</a></li>
        <li style="<?php echo $hiddenStyle ?>"><a href="logIn.php">Log In</a></li>
        <li style="<?php echo $style ?>"><a href="addPost.php">Add Post</a></li>
        <li style="<?php echo $style ?>"><a href="MyPosts.php">My Posts</a></li>
        <li style="float:right;<?php echo $style ?>"><a href='php/logOut.php' name="logOut" > Log Out</a></li>
       
        
        
    </ul>
</div>
  <script src="http://code.jquery.com/jquery-1.11.3.min.js" > </script>

	<script>
function myFunction() {
  var x = document.getElementById("menu");
    if (x.style.display === "none") {
        x.style.display = "block";
        x.style.height = "auto";
    } else {
        x.style.display = "none";
        x.style.height = "0px";
    }
    
  
    
};
        
 
 
</script>

