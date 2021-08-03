app.controller("product",function($scope,$http,ajax){
    ajax.get(API_ROOT+"/api/Product/GetAll",success,error);
    function success(response) {
        $scope.product = response.data;
    }
    function error(error) {

    }
    
});