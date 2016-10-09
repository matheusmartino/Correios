(function () {

    angular.module('cepFacilBr').config(function ($routeProvider, $locationProvider) {
        $routeProvider
        .when('/home', {
            controller: 'homeCtrl',
            controllerAs: 'home',
            templateUrl: 'pages/home.html',
            authorize: true
        })

        .when('/cep/consulta/:cep/json', {
            controller: 'jsonCtrl',
            controllerAs: 'jsn',
            templateUrl: 'pages/json.html',
            authorize: true
        })       
    });
})();