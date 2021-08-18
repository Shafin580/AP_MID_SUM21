app.controller("Login",function($scope,$http,ajax,$location){
    $scope.login = function(){
        ajax.get(API_ROOT+"api/Login/"+$scope.username,success,error);
        function success(response){
            user = response.data;
            if(user.LoginUsername == $scope.username && user.LoginPassword == $scope.password){
                if(user.UserType == "Customer"){
                    $location.path("/CustomerHome");
                }
                else if(user.UserType == "Courier"){
                    $location.path("/CourierHome");
                }
                else if(user.UserType == "Admin"){
                    $location.path("/AdminHome");
                }
                
            }
        }
        function error(err){
            $location.path("/Login");
        }
    }
});