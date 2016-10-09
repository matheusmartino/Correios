(function () {
    angular.module('cepFacilBr').controller('homeCtrl', homeCtrl);

    homeCtrl.$inject = ['$rootScope', '$http', '$route', '$location', 'SETTINGS'];

    function homeCtrl($rootScope, $http, $route, $location, SETTINGS) {
        var home = this;
        home.texto = '';
        home.data = '';
        home.endereco = '';
        home.success = false;
        home.fail = false;
        home.complento1Success = false;
        home.complento2Success = false;
        var map;
        var marker = [];

        activate();

        function activate() {            
            initialize();
           // google.maps.event.addDomListener(window, 'load', initialize);
        }

        home.ceptSearch = function Pesquisa() {
            $http.get(SETTINGS.SERVICE_URL + 'cep/consulta/' + home.texto)
                .then(success).catch(fail);
            function success(result) {                
                home.data = result.data
                console.log(home.data.end);
                home.endereco = home.data.end;
                home.success = true;
                home.fail = false;
                home.complento1Success = home.data.complemento.length!=0 ? true : false;
                home.complento2Success = home.data.complemento2.length != 0 ? true : false;
                searchAddress();
            }
            function fail(result) {
                home.fail = true;
                home.success = false;
                home.data = result.data;
                console.log(home.data.end);
            }
        }

        function initialize() {

            var mapOptions = {
                center: new google.maps.LatLng(-21.159882, -47.831623),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };

            map = new google.maps.Map(document.getElementById("map-canvas"), mapOptions);
        }
              
        function searchAddress() {

            var addressInput = home.data.end + ' ' + home.data.bairro + ' ' + home.data.cidade;
            //alert(home.data.end);

            var geocoder = new google.maps.Geocoder();

            geocoder.geocode({ address: addressInput }, function (results, status) {

                if (status == google.maps.GeocoderStatus.OK) {

                    var myResult = results[0].geometry.location;

                    createMarker(myResult);

                    map.setCenter(myResult);

                    map.setZoom(17);
                }
            });
        }

        function createMarker(latlng) {
            if (marker != undefined && marker != '') {
                marker.setMap(null);
                marker = '';
            }
            marker = new google.maps.Marker({
                map: map,
                position: latlng,
                zoom:5
            });
        }
    }
})();