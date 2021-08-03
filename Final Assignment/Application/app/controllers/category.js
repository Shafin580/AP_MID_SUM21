app.controller("category",function($scope,$http,ajax){
    ajax.get(API_ROOT+"/api/Category/GetAll",success,error);
    function success(response) {
        $scope.category = response.data;
    }
    function error(error) {

    }
});