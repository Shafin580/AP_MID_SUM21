app.controller("order",function($scope,$http,ajax){
    ajax.get(API_ROOT+"/api/Order/GetAll",success,error);
    function success(response) {
        $scope.order = response.data;
    }
    function error(error) {

    }
});