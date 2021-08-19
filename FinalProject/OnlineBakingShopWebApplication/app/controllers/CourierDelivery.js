app.controller("CourierDelivery",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Transaction/GetAll",success,error);
    function success(response) {
        $scope.transactions = response.data;
    }
    function error(error) {

    }
});