 <?php include 'php/signUp.php'; ?>
<form method="Post">
  <div class="group">
      <input name="UserName" required value="<?php echo $_POST['UserName']; ?>" type="text"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $userNameErr;?></p>
     <label>UserName</label>
  </div>
    
    <div class="group">
    <input name="Password" required value="<?php echo $_POST['Password']; ?>" type="password"><span class="highlight"></span><span class="bar"></span>  
        <p class="error" style="display: inline-block;"><?php echo $userPasswordErr;?></p>
    <label>Password</label>
  </div>
    
  <div class="group">
    <input name="Email" required value="<?php echo $_POST['Email']; ?>" type="email"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $userEmailErr;?></p>
    <label>Email</label>
  </div>
    
    <div class="group">
    <input name="Skills" required value="<?php echo $_POST['Skills']; ?>"  type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $userSkillsErr;?></p>
    <label>skills</label>
  </div>
    <div class="group">
    <img style="padding:0px 10%;" src="php/captcha.php" /><input required type="text" name="captcha" /><p class="error" style="display: inline-block;"><?php echo $captchaErr;?></p>
    </div>
   
    
    
  <button type="submit" name="button" class="button buttonRed">Sign Up
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
   <p style="color:red;"> <?php echo $notify; ?></p>
</form>