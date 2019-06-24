document.addEventListener("deviceready", onReady, false);

function onReady() {
    console.log("navigator.geolocation works well");
    geoLocation();
}






//var onSuccess = function(position) {
//        alert('Latitude: '          + position.coords.latitude          + '\n' +
//              'Longitude: '         + position.coords.longitude         + '\n' +
//              'Altitude: '          + position.coords.altitude          + '\n' +
//              'Accuracy: '          + position.coords.accuracy          + '\n' +
//              'Altitude Accuracy: ' + position.coords.altitudeAccuracy  + '\n' +
//              'Heading: '           + position.coords.heading           + '\n' +
//              'Speed: '             + position.coords.speed             + '\n' +
//              'Timestamp: '         + position.timestamp                + '\n');
//    };


function onError(error) {
    alert('code: ' + error.code + '\n' +
        'message: ' + error.message + '\n');
}





function geoLocation() {
    navigator.geolocation.getCurrentPosition(getRest, onError, {
        timeout: 10000,
        enableHighAccuracy: true
    });
}



function getRest(position) {


    $.ajax({
        url: "https://developers.zomato.com/api/v2.1/geocode?lat=" + position.coords.latitude + "&lon=" + position.coords.longitude,
        dataType: 'json',
        async: true,
        beforeSend: function (xhr) {
            xhr.setRequestHeader('user-key',
                'a221898937735f651a064bb9c6ba20e7');
        }, // This inserts the api key into the HTTP header
        success: function (response) {
            output(response)
        }
    });




    // var request = new XMLHttpRequest();
    // var token = "a221898937735f651a064bb9c6ba20e7";
    // request.open('GET', 'https://developers.zomato.com/api/v2.1/geocode?lat=51.482540&lon=-0.006653', true);
    //  request.setRequestHeader('Authorization', 'user-key:' + token);
    //
    // request.onload = function () {
    //
    //   // Begin accessing JSON data here
    //   var data = JSON.parse(this.response);
    //
    //   if (request.status >= 200 && request.status < 400) {
    //     data.forEach(restaurant => {
    //       console.log(restaurant.name);
    //     });
    //   } else {
    //     console.log('error');
    //   }
    // }
    //
    // request.send();
}


function output(response) {
    var myJSON = JSON.stringify(response);
    var obj = JSON.parse(myJSON);
    var toAdd = document.createDocumentFragment();
    for (var i = 0; i < obj.nearby_restaurants.length; i++) {



        var newDiv = document.createElement('div');
        newDiv.id = 'r' + i;
        newDiv.className = 'card';

        var newH1 = document.createElement('h2');
        newH1.innerHTML = obj.nearby_restaurants[i].restaurant.name;
        var newH2 = document.createElement('h2');
        newH2.innerHTML = obj.nearby_restaurants[i].restaurant.cuisines;
        var newH3 = document.createElement('h2');
        newH3.innerHTML = obj.nearby_restaurants[i].restaurant.location.address;

        var newH4 = document.createElement('h2');
        newH4.innerHTML = "Average Cost for Two:  £" + obj.nearby_restaurants[i].restaurant.average_cost_for_two;

        var newH5 = document.createElement('h2');
        newH5.innerHTML = "Rating: " + obj.nearby_restaurants[i].restaurant.user_rating.aggregate_rating + " " + obj.nearby_restaurants[i].restaurant.user_rating.rating_text;



        var divL = document.createElement('div');
        divL.className = 'col6';
        divL.appendChild(newH1);
        divL.appendChild(newH2);
        divL.appendChild(newH3);
        divL.appendChild(newH4);
        divL.appendChild(newH5);



        newDiv.appendChild(divL);

        var img = document.createElement('img');
        img.className = 'cImg';
        if (obj.nearby_restaurants[i].restaurant.thumb == "") {
            img.src = "https://www.cekindo.com/wp-content/uploads/2018/11/logo-zomato.jpg";
        } else {
            img.src = obj.nearby_restaurants[i].restaurant.thumb;
        }


        var divR = document.createElement('div');
        divR.className = 'col6';
        divR.appendChild(img);
        newDiv.appendChild(divR);
        toAdd.appendChild(newDiv);

    }
    document.getElementById('content').appendChild(toAdd);


}



function handleLocation(position) {
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;
    alert(latitude + "  " + longitude);
}
