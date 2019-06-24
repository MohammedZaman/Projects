//var db = openDatabase('Irate', '1.0', 'Test DB', 9 * 1024 * 1024);
var db;
document.addEventListener("deviceready", onDeviceReady, false);

function onDeviceReady() {
    db = window.openDatabase("Irate'", "1.0", "Test DB", 120000);
    initialize();
    createDB();
}

/* ****************** Validation  ****************** */
function validate() {

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





    if (restaurant == "") {
        //        showAlert();
        var dd = document.getElementById('err1');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err1');
        dd.innerHTML = "";
    }




    if (restType == "Select Type") {
        //        showAlert();
        var dd = document.getElementById('err2');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err2');
        dd.innerHTML = "";
    }



    if (dateOfVisit == "") {
        //        showAlert();
        var dd = document.getElementById('err3');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err3');
        dd.innerHTML = "";

    }




    if (timeOfVisit == "") {
        //        showAlert();
        var dd = document.getElementById('err4');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err4');
        dd.innerHTML = "";

    }


    if (pricePerMeal == 0) {
        //        showAlert();
        var dd = document.getElementById('err5');
        dd.innerHTML = "*";

    } else {
        var dd = document.getElementById('err5');
        dd.innerHTML = "";

    }




    if (serviceRate == 0) {
        //        showAlert();
        var dd = document.getElementById('err6');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err6');
        dd.innerHTML = "";

    }


    if (cleannessRate == 0) {
        //        showAlert();
        var dd = document.getElementById('err7');
        dd.innerHTML = "*";

    } else {
        var dd = document.getElementById('err7');
        dd.innerHTML = "";

    }


    if (foodQaulityRate == 0) {
        //        showAlert();
        var dd = document.getElementById('err8');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err8');
        dd.innerHTML = "";
    }



    if (loc == "") {
        //         showAlert();
        var dd = document.getElementById('err9');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err9');
        dd.innerHTML = "";
    }


    if (nameOfreporter == "") {
        //        showAlert();
        var dd = document.getElementById('err10');
        dd.innerHTML = "*";
    } else {
        var dd = document.getElementById('err10');
        dd.innerHTML = "";
    }


    if (restaurant != "" && restType != "Select Type" && dateOfVisit != "" && timeOfVisit != "" && pricePerMeal != 0 &&
        serviceRate != 0 && cleannessRate != 0 && foodQaulityRate != 0 && loc != "" && nameOfreporter != "") {

        duplicate(restaurant);


    } else {
        showAlert();
    }









}

/* ****************** Insert into the database  ****************** */
function insertRecord(tx) {
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
    var long = document.getElementsByName('longitude')[0].value;
    var lat = document.getElementsByName('latitude')[0].value;
    var loc = document.getElementsByName('loc')[0].value;





    db.transaction(function (tx) {
        tx.executeSql('INSERT INTO Review (rest_name,rest_type,DateOv,TimeOv,pricePP,Service_rate, Clean_Rate,Food_Qaul,Notes,Name_Of_Reporter,Long,Lat,Loc) VALUES (?, ?, ?, ?, ?, ?, ? ,? ,? ,? , ? , ? , ?)', [restaurant, restType, dateOfVisit, timeOfVisit, pricePerMeal, serviceRate, cleannessRate, foodQaulityRate, notes, nameOfreporter, long, lat, loc], SuccessInsert, errorInsert);
        //   tx.executeSql('INSERT INTO Review (rest_name, rest_type) (?,?)', [restaurant,restType], SuccessInsert, errorInsert);

    });




}

// if the sql does insert

function SuccessInsert(tx, result) {
    var restaurant = document.getElementsByName('restaurant')[0].value;
    showSuccess(restaurant);
    location.reload();

}


// if the sql does not insert
function errorInsert(error) {
    alert("Error processing SQL: " + error.code);
}


function createDB() {
    db.transaction(function (tx) {
        tx.executeSql('CREATE TABLE IF NOT EXISTS Review (Review_ID INTEGER PRIMARY KEY AUTOINCREMENT,rest_name TEXT, rest_type TEXT,DateOv TEXT,TimeOv TEXT,pricePP INTEGER,Service_rate INTEGER, Clean_Rate INTEGER,Food_Qaul INTEGER,Notes TEXT,Name_Of_Reporter TEXT,Long TEXT,Lat TEXT, Loc TEXT)');
    });
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


// alert dialog dismissed
function confrimDismissed() {
    // do something
}

// Show a custom alertDismissed
//
function showSuccess(rest) {

    navigator.notification.alert(
        'Review Added for ' + rest, // message
        confrimDismissed, // callback
        'Alert', // title
        'Ok' // buttonName
    );
}

// alert dialog dismissed
function duplicateDismissed() {
    // do something
}

// Show a custom alertDismissed
//
function showDuplicate(rest) {

    navigator.notification.alert(
        'Review for ' + rest + ' Already Exists', // message
        duplicateDismissed(), // callback
        'Alert', // title
        'Ok' // buttonName
    );
}



// autoComplete Places
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




// checking for duplicate records
function duplicate(rest) {
    db = window.openDatabase("Irate'", "1.0", "Test DB", 1000000);
    db.transaction(function (tx) {
        tx.executeSql('CREATE TABLE IF NOT EXISTS Review (Review_ID INTEGER PRIMARY KEY AUTOINCREMENT,rest_name TEXT, rest_type TEXT,DateOv TEXT,TimeOv TEXT,pricePP INTEGER,Service_rate INTEGER, Clean_Rate INTEGER,Food_Qaul INTEGER,Notes TEXT,Name_Of_Reporter TEXT)');
    });
    query = "SELECT * FROM Review WHERE rest_name ='" + "" + rest + "'";
    db.transaction(function (transaction) {
        transaction.executeSql(query, [], function (tx, results) {
            if (results.rows.length == 0) {
                insertRecord();
            } else {
                showDuplicate(rest);
            }
        }, null);
    });
}
