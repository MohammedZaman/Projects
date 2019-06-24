<?php include 'php/MyPosts.php'; ?>

<form method ="Post" style="width:100%; background-color:transparent; border:0px; box-shadow: rgba(0,0,0,0) 0px 0px 0px 0px,rgba(0,0,0,0) 0px 0px 0px 0px; padding:0px;">
<div class="posts" >
    <?php while($post = mysqli_fetch_assoc($posts)): ?> 
<div class="card"  id="<?=$post['PostID']?>">

    <div class=col-6>
     <h4>Task Type: <?= $post['TaskType'];?></h4>
     <h4>Skills Required: <?= $post['SkillsReq'];?></h4>
        <h4>Task Location: <?= $post['TaskLocation'];?></h4>
        <h4>Credits Awarded: <?= $post['CreditAwarded'];?></h4>  
 </div>   
     <div class=col-7>
 <?php
$sth = $conn->query("SELECT image FROM images WHERE PostID = '" . $post['PostID'] . "'");
while($result = mysqli_fetch_assoc($sth)):
echo '<img id="myImg" style ="width:47%;height:auto;margin:2px" src="data:image/jpeg;base64,'.base64_encode( $result['image'] ).'"/>';
 endwhile
?>

 </div> 
     <div class=col-3>
<h3 style="text-align:center;">Status</h3>
<h3 style="text-align:center;"><?php if($post['Status'] == 1){
echo "&#10004;";
}elseif ($post['Status'] == 0){
 echo "&#9744;";   
} ?></h3>
<br>
         
<h6>Added by: <?=$post['AddedBy']?> </h6>
 </div> 

    
    <div class="col-4" >
     <button type="submit" style="margin:5% 0px;" class="button buttonRed" name="id" value="[<?= $post['PostID']; ?>]"> Edit </button>
        
    <button type="submit" style="margin:5% 0px;" class="button buttonRed" name="del" value="[<?= $post['PostID']; ?>]">Delete</button>
        
    <button type="submit" style="margin:5% 0px;" class="button buttonRed" name="uploadImg" value="[<?= $post['PostID']; ?>]">Upload Images</button>
        
     <?php
     $check = mysqli_query($conn, "select * from images where PostID ='".$post['PostID']."'");
     $checkrows = mysqli_num_rows($check);
        
    if ($checkrows == 0) { ?>   
    <button type="submit" style="margin:5% 0px;" disabled class="button disabled buttonRed" name="deleteImg"  title="No images to delete" value="[<?= $post['PostID']; ?>]">Delete Images</button>
    <?php }else{?>     
   <button type="submit" style="margin:5% 0px;" class="button buttonRed" name="deleteImg" value="[<?= $post['PostID']; ?>]">Delete Images</button>             <?php }?>
    </div>
   
    </div>
    <?php endwhile ?>  
</div>
    
    <?php
     $checkrows = mysqli_num_rows($posts);
     if ($checkrows == 0){
    ?>
    <div class="noPosts">
    <h2 style="color:white; font-size:25px"><b>Oh no!</b> <br> <br> You have no posts</h2>
    <br>
    <img style="width:100%; height:auto" src="img/sEmoji.png" alt="sad emoji">
    </div>
    
    
    <?php }?>
    </form>