app.controller("CustomerTransaction",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Transaction/"+user.Id,success,error);
    function success(response) {
        $scope.transactions = response.data;
    }
    function error(error) {

    }
});