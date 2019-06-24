<?php include 'php/verify.php';?>
<form method="Post">
    <div class="group">
        <input required name="VerifCode" maxlength="5"  value="<?php echo $_POST['VerifCode']; ?>"  type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $verifyErr; ?></p>
        <label>Verification Code</label>
    </div>

    <button type="submit" name="verify" class="button buttonRed">Verify
        <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
    </button>
    <p style="color:red;"> <?php echo $notify; ?></p>
   
</form>

