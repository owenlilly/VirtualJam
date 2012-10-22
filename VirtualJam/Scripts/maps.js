//
// Google Maps JavaScript file
//
$(document).ready(function () {

    //
    // The Map events
    //
    $('#getCenter').click(function () {
        alert('The center is: '+ map.getCenter());
    });

    $('#getZoom').click(function () {
        alert('The zoom is: ' + map.getZoom());
    });

    //
    // The Map options
    //
    var mapDiv = document.getElementById('map'); // map element
    var latlng = new google.maps.LatLng(18.127295215406242, -77.28318115234374); // centre coordinates (Jamaica)
    
    var options = {
            center: latlng,
            zoom: 9,
            disableDefaultUI: true,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            mapTypeControl: true,
            mapTypeControlOptions: {
                style: google.maps.MapTypeControlStyle.DROPDOWN_MENU,
                mapTypeIds: [
                    google.maps.MapTypeId.ROADMAP,
                    google.maps.MapTypeId.SATELLITE
                ]
            }
            //navigationControl: true
        }; // Options
    
    // The MAP
    var map = new google.maps.Map(mapDiv, options);

});