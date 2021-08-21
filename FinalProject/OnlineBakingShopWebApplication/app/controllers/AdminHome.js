app.controller("AdminHome",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Customer/GetAll",success,error);
    function success(response) {
        $scope.customers = response.data;
    }
    function error(error) {

    }

    ajax.get(API_ROOT+"api/Courier/GetAll",suc,err);
    function suc(response) {
        $scope.couriers = response.data;
    }
    function err(error) {

    }
});