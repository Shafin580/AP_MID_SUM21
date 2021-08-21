app.controller("AdminTransactions",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Transaction/All/Details",success,error);
    function success(response) {
        $scope.transactions = response.data;
    }
    function error(error) {

    }
});