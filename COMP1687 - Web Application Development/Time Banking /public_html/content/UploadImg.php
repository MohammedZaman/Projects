<?php include 'php/UploadImg.php';?>

<form style="color:black;" method="post" enctype="multipart/form-data">
    Select image to upload(Max 6):

    <input type="file" name="image" />
      <p style="color:red;">
        <?php echo $notify; ?>
    </p>
    <div class="group">


        <input required placeholder="Image Name"  value="<?php echo $_POST['imgName']; ?>"  name="imgName" type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;">
            <?php echo $imgNameErr; ?>
        </p>

    </div>

    <div class="group">

        <input required placeholder="Alt Image Name" name="altName"  value="<?php echo $_POST['altName']; ?>"  type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;">
            <?php echo $altNameErr;?>
        </p>

    </div>
    
    <button type="submit" style="margin:5% 0px;" class="button buttonRed" name="submit" value="UPLOAD">Upload</button>
  

</form>