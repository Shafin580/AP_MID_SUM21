app.controller("CustomerMenu",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Product/GetAll",success,error);
    function success(response) {
        $scope.products = response.data;
    }
    function error(error) {

    }
});