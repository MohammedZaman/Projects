 <?php include 'php/addPost.php'; ?>
<form method="Post">
  <div class="group">
      <input name="taskType" required  value="<?php echo $_POST['taskType']; ?>"  type="text"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $tasktypeErr;?></p>
     <label>Task Type</label>
  </div>
    
  <div class="group">
    <input name="skillsReq" required  value="<?php echo $_POST['skillsReq']; ?>"  type="text"><span class="highlight"></span><span class="bar"></span>
      <p class="error" style="display: inline-block;"><?php echo $skillReqErr;?></p>
    <label>Skills Required</label>
  </div>
    
    <div class="group">
    <input name="taskLoc" id="taskLoc" required value="<?php echo $_POST['taskLoc']; ?>"  type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $taskLocErr;?></p>
    <label>Task Location</label>
  </div>
    
       <div class="group">
    <input name="credit" required value="<?php echo $_POST['credit']; ?>"  maxlength="3"  type="text"><span class="highlight"></span><span class="bar"></span>
        <p class="error" style="display: inline-block;"><?php echo $creditErr;?></p>
    <label>Credits Awarded</label>
  </div>
    
   <div class="group">
    <label>Status</label>
    <span class="custom-dropdown big">
    <select name="status">    
        <option value="0">Open</option>  
        <option value="1">Completed</option>
    </select>
</span>
        <p class="error" style="display: inline-block;"><?php echo $StatusErr;?></p>
</div>
    
  <button style="margin-top:20px;" type="submit" name="addPost" class="button buttonRed">Add Post<div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
  </button>
    
   <p style="color:red;"> <?php echo $notify; ?></p>
</form>



<!--JS script -->
<script  type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD0d26RqslIEWmn-m7JjZW6SGw-koOw9HI&libraries=places"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

<script>
function initialize() {
        var searchBox = document.getElementById('taskLoc');
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
    
    
    
</script>

