var db;
document.addEventListener("onReady", view(), false);


/* ****************** Dynamic load for restaurant dropdown  ****************** */
function view() {
    initialize();
    db = window.openDatabase("Irate'", "1.0", "Test DB", 1200000);
    db.transaction(function (tx) {
        tx.executeSql('CREATE TABLE IF NOT EXISTS Review (Review_ID INTEGER PRIMARY KEY AUTOINCREMENT,rest_name TEXT, rest_type TEXT,DateOv TEXT,TimeOv TEXT,pricePP INTEGER,Service_rate INTEGER, Clean_Rate INTEGER,Food_Qaul INTEGER,Notes TEXT,Name_Of_Reporter TEXT,Long TEXT,Lat TEXT, Loc TEXT)');
    });
    db.transaction(function (transaction) {
        transaction.executeSql('SELECT * FROM Review', [], function (tx, results) {

            var select = document.getElementById('restSelect');
            for (var i = 0; i < results.rows.length; i++) {
                var id = results.rows.item(i).Review_ID;
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
                select.options[select.options.length] = new Option(rest, id);

            }




        }, null);
    });
}
/* ****************** Dynamic Load  ****************** */
function loadRest() {
    db = window.openDatabase("Irate'", "1.0", "Test DB", 1200000);
    db.transaction(function (tx) {
        tx.executeSql('CREATE TABLE IF NOT EXISTS Review (Review_ID INTEGER PRIMARY KEY AUTOINCREMENT,rest_name TEXT, rest_type TEXT,DateOv TEXT,TimeOv TEXT,pricePP INTEGER,Service_rate INTEGER, Clean_Rate INTEGER,Food_Qaul INTEGER,Notes TEXT,Name_Of_Reporter TEXT,Long TEXT,Lat TEXT, Loc TEXT)');
    });
    db.transaction(function (transaction) {
        transaction.executeSql('SELECT * FROM Review', [], function (tx, results) {

            var select = document.getElementById('restSelect');

            var i = select.options[select.selectedIndex].value - 1;
            var id = results.rows.item(i).Review_ID;
            var rest = results.rows.item(i).rest_name;
            var restT = results.rows.item(i).rest_type;
            var dateo = results.rows.item(i).DateOv;
            var timeo = results.rows.item(i).TimeOv;
            var ppp = results.rows.item(i).pricePP;
            var sR = results.rows.item(i).Service_rate;
            var cR = results.rows.item(i).Clean_Rate;
            var fQ = results.rows.item(i).Food_Qaul;
            var loc = results.rows.item(i).Loc;
            var long = results.rows.item(i).Long;
            var lat = results.rows.item(i).Lat;
            var no = results.rows.item(i).Notes;
            var nor = results.rows.item(i).Name_Of_Reporter;

            document.getElementsByName('restaurant')[0].value = rest;
            document.getElementById('restType').selectedIndex = findIndex(restT);
            document.getElementsByName('dateOfVisit')[0].value = dateo;
            document.getElementsByName('timeOfVisit')[0].value = timeo;
            document.getElementsByName('ppmSlider')[0].value = ppp;
            document.getElementsByName('srSlider')[0].value = sR;
            document.getElementsByName('crSlider')[0].value = cR;
            document.getElementsByName('fqrSlider')[0].value = fQ;
            document.getElementsByName('notesTxt')[0].value = no;
            document.getElementsByName('nameOfReporterTxt')[0].value = nor;
            document.getElementsByName('latitude')[0].value = lat;
            document.getElementsByName('longitude')[0].value = long;
            document.getElementsByName('loc')[0].value = loc;


            $('#ppmSlider').slider("refresh");
            $('#srSlider').slider("refresh");
            $('#crSlider').slider("refresh");
            $('#fqrSlider').slider("refresh");
            $('#restType').selectmenu("refresh");


        }, null);
    });



}

function findIndex(text) {
    var textToFind = text;

    var dd = document.getElementById('restType');
    for (var i = 0; i < dd.options.length; i++) {
        if (dd.options[i].text === textToFind) {
            dd.selectedIndex = i;
            return i;
            break;
        }
    }
    return 0;
}

// validation for form
function validateUpdate() {

    var ddrest = document.getElementById('restSelect');
    var selRest = ddrest.options[ddrest.selectedIndex].text;
    var restaurant = document.getElementsByName('restaurant')[0].value;
    var dd = document.getElementById('restType');
    var restType = dd.options[dd.selectedIndex].text;
    var dateOfVisit = document.getElementsByName('dateOfVisit')[0].value;
    var timeOfVisit = document.getElementsByName('timeOfVisit')[0].value;
    var pricePerMeal = document.getElementsByName('ppmSlider')[0].value;
    var serviceRate = document.getElementsByName('srSlider')[0].value;
    var cleannessRate = document.getElementsByName('crSlider')[0].value;
    var foodQaulityRate = document.getElementsByName('fqrSlider')[0].value;
    var notes = document.getElementsByName('notesTxt')[0].value;
    var nameOfreporter = document.getElementsByName('nameOfReporterTxt')[0].value;
    var loc = document.getElementsByName('loc')[0].value;

    if (selRest == "Select Place") {
        var dd = document.getElementById('err1');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err1');
        dd.innerHTML = "";
    }


    if (restaurant == "") {
        //        showAlert();
        var dd = document.getElementById('err2');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err2');
        dd.innerHTML = "";
    }




    if (restType == "Select Type") {
        //        showAlert();
        var dd = document.getElementById('err3');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err3');
        dd.innerHTML = "";
    }



    if (dateOfVisit == "") {
        //        showAlert();
        var dd = document.getElementById('err4');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err4');
        dd.innerHTML = "";

    }




    if (timeOfVisit == "") {
        //        showAlert();
        var dd = document.getElementById('err5');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err5');
        dd.innerHTML = "";

    }


    if (pricePerMeal == 0) {
        //        showAlert();
        var dd = document.getElementById('err6');
        dd.innerHTML = "*";

    } else {
        var dd = document.getElementById('err6');
        dd.innerHTML = "";

    }




    if (serviceRate == 0) {
        //        showAlert();
        var dd = document.getElementById('err7');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err7');
        dd.innerHTML = "";

    }


    if (cleannessRate == 0) {
        //        showAlert();
        var dd = document.getElementById('err8');
        dd.innerHTML = "*";

    } else {
        var dd = document.getElementById('err8');
        dd.innerHTML = "";

    }


    if (foodQaulityRate == 0) {
        //        showAlert();
        var dd = document.getElementById('err9');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err9');
        dd.innerHTML = "";
    }



    if (loc == "") {
        //         showAlert();
        var dd = document.getElementById('err10');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err10');
        dd.innerHTML = "";
    }


    if (nameOfreporter == "") {
        //        showAlert();
        var dd = document.getElementById('err11');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err11');
        dd.innerHTML = "";
    }




    if (restaurant != "" && restType != "Select Type" && dateOfVisit != "" && timeOfVisit != "" && pricePerMeal != 0 &&
        serviceRate != 0 && cleannessRate != 0 && foodQaulityRate != 0 && loc != "" && nameOfreporter != "" && selRest != "Select Place") {

        updateRecord();


    } else {
        showAlert();
    }




}

function updateRecord(tx) {
    var restaurant = document.getElementsByName('restaurant')[0].value;
    var dd = document.getElementById('restType');
    var restType = dd.options[dd.selectedIndex].text;
    var dateOfVisit = document.getElementsByName('dateOfVisit')[0].value;
    var timeOfVisit = document.getElementsByName('timeOfVisit')[0].value;
    var pricePerMeal = document.getElementsByName('ppmSlider')[0].value;
    var serviceRate = document.getElementsByName('srSlider')[0].value;
    var cleannessRate = document.getElementsByName('crSlider')[0].value;
    var foodQaulityRate = document.getElementsByName('fqrSlider')[0].value;
    var notes = document.getElementsByName('notesTxt')[0].value;
    var nameOfreporter = document.getElementsByName('nameOfReporterTxt')[0].value;

    var lat = document.getElementsByName('latitude')[0].value;
    var long = document.getElementsByName('longitude')[0].value;
    var loc = document.getElementsByName('loc')[0].value;

    var select = document.getElementById('restSelect');
    var id = select.options[select.selectedIndex].value;

    db.transaction(function (tx) {
        tx.executeSql("UPDATE  Review SET rest_name = '" + restaurant + "', rest_type = '" + restType + "',TimeOv = '" + timeOfVisit + "',pricePP = '" + pricePerMeal + "',Service_rate = '" + serviceRate + "', Clean_Rate = '" + cleannessRate + "',Food_Qaul ='" + foodQaulityRate + "', Notes = '" + notes + "',Name_Of_Reporter ='" + nameOfreporter + "',Long ='" + long + "',Lat ='" + lat + "',Loc ='" + loc + "'" + "WHERE Review_ID ='" + id + "'", [], SuccessInsert, errorInsert);
        //   tx.executeSql('INSERT INTO Review (rest_name, rest_type) (?,?)', [restaurant,restType], SuccessInsert, errorInsert);
    });

}


function SuccessInsert(tx, result) {
    var rest = document.getElementsByName('restaurant')[0].value;
    showUpdate(rest);
    location.reload();

}



function errorInsert(error) {
    alert("Error processing SQL: " + error.code);
}

function showUpdate(rest) {

    navigator.notification.alert(
        'Entry Updated for ' + rest, // message
        confrimDismissed, // callback
        'Alert', // title
        'Ok' // buttonName
    );
}

// alert dialog dismissed
function confrimDismissed() {
    // do something
}


// alert dialog dismissed
function alertDismissed() {
    // do something
}

// Show a custom alertDismissed
//
function showAlert() {
    navigator.vibrate(200);
    navigator.notification.alert(
        'Please fill in the required fields', // message
        alertDismissed, // callback
        'Alert!', // title
        'Ok' // buttonName
    );
}

function initialize() {
    var searchBox = document.getElementById('loc');
    var autocomplete = new google.maps.places.Autocomplete(searchBox);
    var latitude;
    var longitude;

    google.maps.event.addListener(autocomplete, 'place_changed', function () {
        var place = autocomplete.getPlace();

        latitude = place.geometry.location.lat();
        longitude = place.geometry.location.lng();
        document.getElementById('latitude').value = place.geometry.location.lat();
        var long = place.geometry.location.lng();
        var cutLong = long.toFixed(6);
        document.getElementById('longitude').value = cutLong;
    });
}
