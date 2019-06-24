var db;

var query;


function validateSearch() {
    var searchInput = document.getElementsByName('sInput')[0].value;
    var filterDD = document.getElementById('filter');
    var filter = filterDD.options[filterDD.selectedIndex].text;
    if (searchInput == "") {
        showAlert();
    } else if (filter == "Select Filter") {
        showAlert();
    } else {
        search();
    }
}




function search() {

    var searchInput = document.getElementsByName('sInput')[0].value;
    var filterDD = document.getElementById('filter');
    var filterV = filterDD.options[filterDD.selectedIndex].value;


    if (filterV == 1) {
        query = "SELECT * FROM Review WHERE rest_name Like '" + "%" + searchInput + "%'";
        view();
    } else if (filterV == 2) {
        query = "SELECT * FROM Review WHERE rest_type Like '" + "%" + searchInput + "%'";
        view();
    } else if (filterV == 3) {
        query = "SELECT * FROM Review WHERE Loc Like '" + "%" + searchInput + "%'";
        view();
    }
}

/* ****************** Dynamic Load  ****************** */
function view() {
    removeChild();

    db = window.openDatabase("Irate'", "1.0", "Test DB", 1000000);
    db.transaction(function (tx) {
        tx.executeSql('CREATE TABLE IF NOT EXISTS Review (Review_ID INTEGER PRIMARY KEY AUTOINCREMENT,rest_name TEXT, rest_type TEXT,DateOv TEXT,TimeOv TEXT,pricePP INTEGER,Service_rate INTEGER, Clean_Rate INTEGER,Food_Qaul INTEGER,Notes TEXT,Name_Of_Reporter TEXT,Long TEXT,Lat TEXT, Loc TEXT)');
    });
    db.transaction(function (transaction) {
        transaction.executeSql(query, [], function (tx, results) {

            var toAdd = document.createDocumentFragment();
            if (results.rows.length == 0) {
                var div = document.createElement('div');
                var ErrorH1 = document.createElement('h3');
                ErrorH1.innerHTML = "No Search Results Found";
                div.appendChild(ErrorH1);
                toAdd.appendChild(div);


            } else {
                for (var i = 0; i < results.rows.length; i++) {
                    var rest = results.rows.item(i).rest_name;
                    var restT = results.rows.item(i).rest_type;
                    var dateo = results.rows.item(i).DateOv;
                    var timeo = results.rows.item(i).TimeOv;
                    var ppp = results.rows.item(i).pricePP;
                    var sR = results.rows.item(i).Service_rate;
                    var cR = results.rows.item(i).Clean_Rate;
                    var fQ = results.rows.item(i).Food_Qaul;
                    var no = results.rows.item(i).Notes;
                    var nor = results.rows.item(i).Name_Of_Reporter;

                    var newH1 = document.createElement('h2');
                    newH1.innerHTML = "Restaurant: " + rest;
                    var newH2 = document.createElement('h2');
                    newH2.innerHTML = "Restaurant Type: " + restT;
                    var newH3 = document.createElement('h2');
                    newH3.innerHTML = "Date of Visit: " + dateo;
                    var newH4 = document.createElement('h2');
                    newH4.innerHTML = "Time of Visit: " + timeo;
                    var newH5 = document.createElement('h2');
                    newH5.innerHTML = "Price Per Meal: " + "£" + ppp;

                    var newH6 = document.createElement('h2');
                    newH6.innerHTML = "Service Rating: " + sR;
                    var newH7 = document.createElement('h2');
                    newH7.innerHTML = "cleanliness rating: " + cR;
                    var newH8 = document.createElement('h2');
                    newH8.innerHTML = "Food Quality Rating: " + fQ;
                    var newH9 = document.createElement('h2');
                    newH9.innerHTML = "Notes: " + no;
                    var newH10 = document.createElement('h2');
                    newH10.innerHTML = "Name Of Reporter: " + nor;

                    var newDiv = document.createElement('div');
                    newDiv.id = 'r' + i;
                    newDiv.className = 'card';
                    var divL = document.createElement('div');
                    divL.className = 'col6';
                    divL.appendChild(newH1);
                    divL.appendChild(newH2);
                    divL.appendChild(newH3);
                    divL.appendChild(newH4);
                    divL.appendChild(newH5);
                    newDiv.appendChild(divL);

                    var divR = document.createElement('div');
                    divR.className = 'col6';
                    divR.appendChild(newH6);
                    divR.appendChild(newH7);
                    divR.appendChild(newH8);
                    divR.appendChild(newH9);
                    divR.appendChild(newH10);

                    newDiv.appendChild(divR);

                    var addedRate = sR + cR + fQ;
                    var totalrate = (addedRate / 3).toFixed(1);
                    var total = document.createElement('div');
                    total.className = 'col12';
                    var totalH2 = document.createElement('h2');
                    totalH2.innerHTML = "Total Rating: " + totalrate;
                    total.appendChild(totalH2);

                    var divM = document.createElement('div');
                    divM.id = "googleMap" + i;
                    id = "googleMap" + i;
                    divM.className = 'map';



                    newDiv.appendChild(total);
                    newDiv.appendChild(divM);






                    toAdd.appendChild(newDiv);
                }
            }
            document.getElementById('searchResults').appendChild(toAdd);
            var script = document.createElement('script');
            script.setAttribute('src', 'https://maps.googleapis.com/maps/api/js?key=AIzaSyD0d26RqslIEWmn-m7JjZW6SGw-koOw9HI&callback=myMap');
            script.defer = true;
            document.body.appendChild(script);

        }, null);
    });
}

// alert dialog dismissed
function alertDismissed() {
    // do something
}

function showAlert() {
    navigator.vibrate(200);
    navigator.notification.alert(
        'Please fill in the required fields', // message
        alertDismissed, // callback
        'Alert!', // title
        'Ok' // buttonName
    );
}

function removeChild() {
    var myNode = document.getElementById("searchResults");
    while (myNode.firstChild) {
        myNode.removeChild(myNode.firstChild);
    }
}


/* ****************** google load  ****************** */
function myMap() {
    db.transaction(function (transaction) {
        transaction.executeSql('SELECT * FROM Review', [], function (tx, results) {


            for (var i = 0; i < results.rows.length; i++) {
                var long = results.rows.item(i).Long;
                var lat = results.rows.item(i).Lat;

                var myCenter = new google.maps.LatLng(lat, long);
                var marker;
                var mapProp = {
                    center: myCenter,
                    zoom: 15,
                    mapTypeId: google.maps.MapTypeId.hybrid
                };

                var map = new google.maps.Map(document.getElementById("googleMap" + i), mapProp);

                var marker = new google.maps.Marker({
                    position: myCenter,
                    icon: 'img/food.png'
                });

                marker.setMap(map);



            }

        }, null);
    });

}
