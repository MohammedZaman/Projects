var db;
document.addEventListener("", view(), false);





/* ****************** Dynamic Load  ****************** */

function view() {
    db = window.openDatabase("Irate'", "1.0", "Test DB", 1000000);
    db.transaction(function (tx) {
        tx.executeSql('CREATE TABLE IF NOT EXISTS Review (Review_ID INTEGER PRIMARY KEY AUTOINCREMENT,rest_name TEXT, rest_type TEXT,DateOv TEXT,TimeOv TEXT,pricePP INTEGER,Service_rate INTEGER, Clean_Rate INTEGER,Food_Qaul INTEGER,Notes TEXT,Name_Of_Reporter TEXT)');
    });
    db.transaction(function (transaction) {
        transaction.executeSql('SELECT * FROM Review', [], function (tx, results) {

            var toAddBtn = document.createDocumentFragment();
            var div = document.createElement('div');
            if (results.rows.length > 0) {
                var button = document.createElement('button');
                button.setAttribute("onclick", "deleteOnConfrim();return false;");
                button.innerHTML = "Delete All";
                button.name = "del";
                button.className = "btn";
                div.appendChild(button);
            } else {
                var h1Error = document.createElement('h1');
                h1Error.innerHTML = "You have no Reviews ";
                div.appendChild(h1Error);
            }

            toAddBtn.appendChild(div);
            document.getElementById('delete').appendChild(toAddBtn);

            var toAdd = document.createDocumentFragment();
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

                var long = results.rows.item(i).Long;
                var lat = results.rows.item(i).Lat;

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


                // Map
                var divM = document.createElement('div');
                divM.id = "googleMap" + i;
                id = "googleMap" + i;
                divM.className = 'map';

                // Delete button
                var del = document.createElement('div');
                del.className = 'col12W';
                var id = results.rows.item(i).Review_ID;
                var delButton = document.createElement('button');
                delButton.setAttribute("onclick", "deleteOneConfrim(" + id + ")");
                delButton.innerHTML = "Delete";
                delButton.name = "del";
                delButton.className = "btn";
                del.appendChild(delButton);


                newDiv.appendChild(total);
                newDiv.appendChild(del);
                newDiv.appendChild(divM);

                toAdd.appendChild(newDiv);



            }

            document.getElementById('content').appendChild(toAdd);
            var script = document.createElement('script');
            script.setAttribute('src', 'https://maps.googleapis.com/maps/api/js?key=AIzaSyD0d26RqslIEWmn-m7JjZW6SGw-koOw9HI&callback=myMap');
            script.defer = true;
            document.body.appendChild(script);


        }, null);
    });
}




/* ****************** delete all  ****************** */
function onConfirm(buttonIndex) {
    if (buttonIndex == 1) {
        deleteTable();
    } else {}

}

function deleteOnConfrim() {
    navigator.notification.confirm(
        'Are you sure you want to delete all reviews', // message
        onConfirm, // callback to invoke with index of button pressed
        'Alert!', // title
    ['Yes', 'No'] // buttonLabels
    );
}

function deleteTable() {
    location.reload();
    db.transaction(function (tx) {
        tx.executeSql('DROP TABLE Review');
    });
}







/* ******************  Dynamic maps  ****************** */
function myMap() {
    db.transaction(function (transaction) {
        transaction.executeSql('SELECT * FROM Review', [], function (tx, results) {


            for (var i = 0; i < results.rows.length; i++) {
                var long = results.rows.item(i).Long;
                var lat = results.rows.item(i).Lat;
                var loc = results.rows.item(i).Loc;

                var myCenter = new google.maps.LatLng(lat, long);
                var marker;
                var mapProp = {
                    center: myCenter,
                    zoom: 15,
                    mapTypeId: google.maps.MapTypeId.hybrid,
                    mapTypeControl: true,
                    mapTypeControlOptions: {
                        style: google.maps.MapTypeControlStyle.DROPDOWN_MENU,
                        mapTypeIds: ['roadmap', 'terrain']
                    }


                };



                var map = new google.maps.Map(document.getElementById("googleMap" + i), mapProp);

                var marker = new google.maps.Marker({
                    position: myCenter,
                    icon: 'img/food.png'
                });

                marker.setMap(map);

                var infowindow = new google.maps.InfoWindow({
                    content: loc
                });


                infowindow.open(map, marker);




            }


        }, null);
    });

}







/* ****************** delete single review  ****************** */
var delId;

function onOneConfirm(buttonIndex) {
    if (buttonIndex == 1) {
        deleteRecord(delId);
    } else {}

}

function deleteOneConfrim(id, rest) {
    delId = id;
    navigator.notification.confirm(
        'Are you sure you want to delete this review', // message
        onOneConfirm, // callback to invoke with index of button pressed
        'Alert!', // title
    ['Yes', 'No'] // buttonLabels
    );

}

function SuccessInsert(tx, result) {
    show();
    location.reload();



}

function errorInsert(error) {
    alert("Error processing SQL: " + error.code);
}

function deleteRecord(id) {

    db.transaction(function (tx) {
        tx.executeSql("Delete From Review Where Review_ID = '" + id + "'", [], SuccessInsert, errorInsert);
        //   tx.executeSql('INSERT INTO Review (rest_name, rest_type) (?,?)', [restaurant,restType], SuccessInsert, errorInsert);

    });

}




/* ******************  Generic native alert  ****************** */


// alert dialog dismissed
function confrimDismissed() {
    // do something
}

// Show a custom alertDismissed
//
function show() {

    navigator.notification.alert(
        'Review Deleted', // message
        confrimDismissed, // callback
        'Alert', // title
        'Ok' // buttonName
    );
}
