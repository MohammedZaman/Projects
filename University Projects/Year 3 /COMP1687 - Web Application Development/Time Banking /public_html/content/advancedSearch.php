<?php include 'php/advancedSearch.php'; ?>
 

<form method="post" class="search">
<h2 style="color:black; padding:0px;">Advanced Search</h2>
<div style="width:100%; padding:20px;"> 
    <div style="display:inline-block; width:100%;">
    <input  type="text" name="param1" style="width:45%; font-size:18px; height:30px; display:inline-block;" >
        <p style="display:inline-block;color:red;"><?= $param1Err;?></p>
       
     <select id="op1" style="font-size:16px; height:35px;width:45%; display:inline-block;" name="op1">
        <option value="TaskLocation">Location</option>  
        <option value="SkillsReq">skills</option>
        <option value="TaskType">TaskType</option>
        <option value="CreditAwarded">Credits Awarded</option>
    </select>
    </div>
  
</div>
    
    <div style="width:100%; padding:20px;"> 
    <div style="display:inline-block; width:100%;">
    <input  type="text" name="param2"  style="width:45%; display:inline-block; font-size:18px; height:30px;" > 
        <p style="display:inline-block;color:red;"><?= $param2Err;?></p>
     <select name="op2" style="width:45%; display:inline-block;font-size:16px; height:35px;">
        <option value="TaskLocation">Location</option>  
        <option value="SkillsReq">skills</option>
        <option value="TaskType">TaskType</option>
        <option value="CreditAwarded">Credits Awarded</option>
    </select>
    </div>
        
    
  <h4 style="color:red; text-align:center;"><?= $error;?></h4>
</div>
    
     <button type="submit" name="button" class="button buttonRed">Search
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
</form>

   

<div class="posts">
    <?php while($post = mysqli_fetch_assoc($posts)): ?> 
<div class="card">
    <div class=col-6>
    <h4 style="color:#0A0068; font-weight: 1000;"><?= $suggested ?></h4>
     <h4>Task Type: <?= $post['TaskType'];?></h4>
     <h4>Skills Required: <?= $post['SkillsReq'];?></h4>
        <h4>Task Location: <?= $post['TaskLocation'];?></h4>
        <h4>Credits Awarded: <?= $post['CreditAwarded'];?></h4>  
 </div>   
     <div class=col-7>
<?php
$sth = $conn->query("SELECT image FROM images WHERE PostID = '" . $post['PostID'] . "'");
while($result = mysqli_fetch_assoc($sth)):
echo '<img id="myImg" alt="'.$result['imgAlt'].'" style ="width:47%;height:auto;margin:2px" src="data:image/jpeg;base64,'.base64_encode( $result['image'] ).'"/>';
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
    
    
    
    
    </div>
    <?php endwhile ?>  
    
   
</div>
<!--<?php echo $page_no." of ".$total_no_of_pages; ?>-->

  <div class="pagination" style="<?= $style ?>">
  <a <?php if($page_no > 1){
echo "href='?page_no=$previous_page'";
} ?>">&laquo;</a>
      
      
<?php for ($i = 1; $i < $total_no_of_pages + 1; $i++) {?>      
  
  <?php if($page_no != $i){ ?>
      
   
      <a href="?page_no=<?php echo $i; ?>"><?= $i?></a>
<?php }else{?>
    
   <a class="active" href="?page_no=<?php echo $i; ?>"><?=$i?></a> 
    
    
<?php }}?>

  <a <?php if($page_no < $total_no_of_pages) {
echo "href='?page_no=$next_page'";
} ?>">&raquo;</a>
</div>













 

