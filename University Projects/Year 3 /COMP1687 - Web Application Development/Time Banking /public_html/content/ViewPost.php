<?php include 'php/ViewPost.php'; ?>


<form method="post" class="search">
      
    <div class="wrap" style="float:left;">
    <span class="custom-dropdown big">
    <select name="Filter" id="Filter"  onchange="change()">
        <option value="TaskLocation">Location</option>  
        <option value="SkillsReq">skills</option>
        <option value="TaskType">TaskType</option>
        <option value="CreditAwarded">Credits Awarded</option>
    </select>
</span>
    </div>
    
   <div class="wrap" style="float:left;">
   <div class="searchbar">
 
      <input type="text" style="display:none;" value="<?= $_COOKIE['lastSearch']?>"  name="searchText" id="searchText" class="searchTerm" placeholder="What are you looking for?">
       
       <input style="width:100%;" name="searchText" class="searchTerm" placeholder="<?= $_COOKIE['lastSearch']?>"  value="<?= $_COOKIE['lastSearch']?>" type="text" id="searchplace" />
       <input type="hidden" id="latitude" name="latitude"/>
<input type="hidden" id="longitude" name="longitude"/>
                                                                                                  
      <button type="submit" name="search" class="searchButton">
        <i class="fa fa-search"></i>
     </button>
   </div>
</div>
  
  <div class="wrap" style="float:left; width:20%;">

 <button type="submit" id="all" style="margin-left:20px;"  name="allBtn" class="button buttonRed">ALL
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>       
    </div>  
 
    <div style="clear:both; margin-bottom:-40px; padding:0px 70px;">
        <button type="submit" href="index.php" style="width:49%; display:inline-block;"  name="advSearch" class="button buttonRed">Advanced Search
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
         <button type="submit" style="width:49%; display:inline-block;"  name="LSearch" class="button buttonRed">Location Search
    <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
    </div>
     
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




<!--JS script -->
<script  type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD0d26RqslIEWmn-m7JjZW6SGw-koOw9HI&libraries=places"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

<script>
function initialize() {
        var searchBox = document.getElementById('searchplace');
        var autocomplete =  new google.maps.places.Autocomplete(searchBox);
        var latitude;
        var longitude;

        google.maps.event.addListener(autocomplete, 'place_changed', function () {
            var place = autocomplete.getPlace();

            latitude = place.geometry.location.lat();
            longitude = place.geometry.location.lng();
            document.getElementById('latitude').value = place.geometry.location.lat();
            document.getElementById('longitude').value = place.geometry.location.lng();                                
        }); 
    }
    google.maps.event.addDomListener(window, 'load', initialize);
    
    function change() {
    var x = document.getElementById("Filter").value;
    var a = document.getElementById("searchplace");
    var b = document.getElementById("searchText");
   
   if(x == "Location"){
    a.style.display = "block";
    b.style.display = "none";
   
   }else{
    b.style.display = "block";
    a.style.display = "none";
   }
}
    
</script>





 

