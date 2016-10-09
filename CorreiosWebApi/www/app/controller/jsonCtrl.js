(function () {
    angular.module('cepFacilBr').controller('jsonCtrl', jsonCtrl);

    jsonCtrl.$inject = ['$rootScope', '$routeParams', '$http', '$route', '$location', 'SETTINGS'];

    function jsonCtrl($rootScope, $routeParams, $http, $route, $location, SETTINGS) {
        var jsn = this;
        jsn.texto = '';
        jsn.data = '';
        jsn.success = false;
        jsn.fail = false;
        jsn.complento1Success = false;
        jsn.complento2Success = false;

        
        Pesquisa();

        function Pesquisa() {
            $http.get(SETTINGS.SERVICE_URL + 'cep/consulta/' + decodeURIComponent($routeParams.cep) + '/json')
                .then(success).catch(fail);
            function success(result) {
                jsn.data = result.data
                console.log(jsn.data);         
            }
            function fail(result) {
                jsn.fail = true;
                jsn.success = false;                
            }
        }
    }
})();