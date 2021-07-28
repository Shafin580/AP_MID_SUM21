var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/home.html"
    })
    .when("/Admin", {
        templateUrl : "views/pages/admin.html",
        //controller: 'demo'
    })
    .when("/Customer", {
        templateUrl : "views/pages/customer.html",
          //controller: 'demo2'
    })
    .when("/Delivery", {
        templateUrl : "views/pages/delivery.html",
        //controller: 'products'
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
