// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



$(document).ready(function () {

    var map, markers = [];
    var urlAPI = 'Classes/WS.php';
    var ZOOM_DEFAULT = 15;
    var myPos = {};
    var myPosVerify = false;
    var openQR = false;
    var CENTER_DEFAULT = {
        lat: -20.320224,
        lng: -40.340440
    };


    carregarMapa();


    function carregarMapa() {
        map = new google.maps.Map(document.getElementById('mapa'), {
            zoom: ZOOM_DEFAULT,
            center: CENTER_DEFAULT,
            zoomControl: true,
            scaleControl: false,
            mapTypeControl: false,
            fullscreenControlOptions: {
                position: google.maps.ControlPosition.LEFT_BOTTOM
            },
            streetViewControlOptions: {
                position: google.maps.ControlPosition.LEFT_BOTTOM
            }/*,
            styles: modeloMapa*/
        });
    }




});