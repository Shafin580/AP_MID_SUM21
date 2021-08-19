var app = angular.module("myApp", ["ngRoute"]);
API_ROOT = "https://localhost:44379/";
var user;
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })
    .when("/CustomerRegistration", {
        templateUrl : "views/pages/CustomerRegistration.html",
        controller: 'CustomerRegistration'
    })
    .when("/CourierRegistration", {
        templateUrl : "views/pages/CourierRegistration.html",
        controller: 'CourierRegistration'
    })
    .when("/CustomerHome", {
        templateUrl : "views/pages/CustomerHome.html",
        controller: 'CustomerHome'
    })
    .when("/CustomerBrownieMenu", {
        templateUrl : "views/pages/CustomerBrownieMenu.html",
        controller: 'CustomerBrownieMenu'
    })
    .when("/CustomerCakeMenu", {
        templateUrl : "views/pages/CustomerCakeMenu.html",
          controller: 'CustomerCakeMenu'
    })
    .when("/CustomerMenu", {
        templateUrl : "views/pages/CustomerMenu.html",
        controller: 'CustomerMenu'
    })
    .when("/CustomerProfile", {
        templateUrl : "views/pages/CustomerProfile.html",
        controller: 'CustomerProfile'
    })
    .when("/CustomerTransaction", {
        templateUrl : "views/pages/CustomerTransaction.html",
        controller: 'CustomerTransaction'
    })
    .when("/AdminHome", {
        templateUrl : "views/pages/AdminHome.html",
        controller: 'AdminHome'
    })
    .when("/CourierHome", {
        templateUrl : "views/pages/CourierHome.html",
        controller: 'CourierHome'
    })
    .when("/CourierProfile", {
        templateUrl : "views/pages/CourierProfile.html",
        controller: 'CourierProfile'
    })
    .when("/CourierDelivery", {
        templateUrl : "views/pages/CourierDelivery.html",
        controller: 'CourierDelivery'
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
