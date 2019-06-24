 <?php include 'php/logIn.php'; ?>
<form method="Post" name="logIn" onsubmit="return validateForm()">
  <div class="group">
      
      <input name="UserName" <?php echo "value='".$_COOKIE["userName"]."'"; ?> type="text"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $userNameErr;?></p>
    <label>UserName</label>
  </div>
    
    <div class="group">
    <input name="Password"  type="password"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $userPasswordErr;?></p>
    <label>Password</label>
  </div>
    <button type="submit"  name="logIn" class="button buttonRed">Sign In
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
    <p style="color:red;"> <?php echo $error; ?></p>
</form>
<script>

function validateForm() {
  var uName = document.forms["logIn"]["UserName"].value;
    var pWord = document.forms["logIn"]["Password"].value;
  if (uName == "" || pWord == "") {
    alert("Please Fill all the fields");
      return false;
  }
  

}
</script>