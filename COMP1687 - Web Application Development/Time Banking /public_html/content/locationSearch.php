<?php include 'php/locationSearch.php'; ?>
<form method="post" class="search">
<h2 style="color:black; padding:0px;">Enter Location</h2>
<div style="width:100%; padding:20px;"> 
    <div style="display:inline-block; width:100%;">
    <input  type="text" name="location" id="location" style="width:45%; font-size:18px; height:30px; display:inline-block;" >
        <p style="display:inline-block;color:red;"><?= $param1Err;?></p>
        <input type="hidden" id="latitude" value="<?= $_POST['latitude']; ?>" name="latitude"/>
<input type="hidden" id="longitude" value="<?= $_POST['longitude']; ?>"  name="longitude"/>
    </div>
  
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
         <h4><?php 
        $details = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=".$location."&destinations=".$post['TaskLocation']."&mode=driving&units=imperial&key=AIzaSyD0d26RqslIEWmn-m7JjZW6SGw-koOw9HI";


    $json = file_get_contents($details);

    $details = json_decode($json, TRUE);
    $miles = print_r($details['rows'][0]['elements'][0]['distance']['text']);
    if($miles == 1){
        echo "";
    }else{
    echo $miles;
    }
        ?></h4>
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
        var searchBox = document.getElementById('location');
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
