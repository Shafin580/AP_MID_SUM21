app.controller("Login",function($scope,$http,ajax,$location){
    $scope.login = function(){
        ajax.get(API_ROOT+"api/Login/"+$scope.username,success,error);
        function success(response){
            user = response.data;
            if(user.LoginUsername == $scope.username && user.LoginPassword == $scope.password){
                if(user.UserType == "Customer"){
                    ajax.get(API_ROOT+"api/Customer/"+$scope.username,a,b);
                    function a(re){
                        user = re.data;
                    }
                    function b(e){

                    }
                    $location.path("/CustomerHome");
                }
                else if(user.UserType == "Courier"){
                    ajax.get(API_ROOT+"api/Courier/"+$scope.username,c,d);
                    function c(res){
                        user = res.data;
                    }
                    function d(e){
                        
                    }
                    $location.path("/CourierHome");
                }
                else if(user.UserType == "Admin"){
                    ajax.get(API_ROOT+"api/Admin/"+$scope.username,e,f);
                    function e(respo){
                        user = respo.data;
                    }
                    function f(erro){
                        
                    }
                    $location.path("/AdminHome");
                }
                
            }
        }
        function error(err){
            $location.path("/Login");
        }
    }
});