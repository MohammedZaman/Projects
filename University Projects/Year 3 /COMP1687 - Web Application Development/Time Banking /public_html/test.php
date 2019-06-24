<?php
include 'includes/head.php';
?>

<head>
    <script  type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD0d26RqslIEWmn-m7JjZW6SGw-koOw9HI&libraries=places"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

</head>
<body>
  


<input style="width:100%;" type="text" id="searchplace"  />
<input type="text" id="latitude" name="latitude"/>
<input type="text" id="longitude" name="longitude"/>
</body>




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
</script>
























<?php
include 'includes/footer.php';
?>