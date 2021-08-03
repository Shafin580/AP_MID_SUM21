var app = angular.module("myApp", ["ngRoute"]);
var API_ROOT = "https://localhost:44336";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/dashboard.html",
        controller: 'dashboard'
    })
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'product'
    })
    .when("/addproduct", {
        templateUrl : "views/pages/addproduct.html",
          controller: 'addproduct'
    })
    .when("/category", {
        templateUrl : "views/pages/category.html",
        controller: 'category'
    })
    .when("/addcategory", {
        templateUrl : "views/pages/addcategory.html",
        controller: 'addcategory'
    })
    .when("/orders", {
        templateUrl : "views/pages/orders.html",
        controller: 'order'
    })
    .when("/addorder", {
        templateUrl : "views/pages/addorder.html",
        controller: 'addorder'
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
