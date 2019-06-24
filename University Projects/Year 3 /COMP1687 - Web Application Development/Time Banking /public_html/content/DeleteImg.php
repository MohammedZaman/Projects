<?php include 'php/DeleteImg.php';?>

<form method="post" style="width:90%; padding:">
<?php
session_start();
$ID1 = $_SESSION["id"];
$ID = str_replace(array('[', ']'), '', $ID1);
$sth = $conn->query("SELECT * FROM images WHERE PostID = '$ID'");  
while($result = mysqli_fetch_assoc($sth)):?>
<div class="imageCard" style="margin-bottom:10px;">
  <div class="col-12">
<?php echo '<img id="myImg" alt="'.$result['imgAlt'].'" style ="width:50%;height:auto;margin:2px; min-width:200px;" src="data:image/jpeg;base64,'.base64_encode( $result['image'] ).'"/>';?>
  </div>
    <div class="col-6">
        <h4>Name: <?= $result['imgName'];?></h4>
        <h4> Alt Name: <?= $result['imgAlt'];?></h4>
        <h4>Date Added: <?php 
        $date = new DateTime($result['created']);
        $strip = $date->format('d-m-y');
        echo $strip;?></h4> 
    </div>
    <div class="col-6">
     <input name ="check_list[]" value="<?= $result['id']?>" type="checkbox" />
    </div>
</div>

<?php endwhile?>
 <div class="group" style="width:40%;padding:20px 30%;">
     <button style="float:right;" type="submit" name="Delete" class="button buttonRed">Delete<div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
 </div>  
    <div>
    <h2 style="color:red; text-align:center;"><?= $delError; ?></h2>
    </div>

</form>
