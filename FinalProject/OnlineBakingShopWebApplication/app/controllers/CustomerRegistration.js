app.controller("CustomerRegistration",function($scope,$http,ajax,$location){
    
    $scope.register = function(){
        var customerdata = {
            name: $scope.name,
            Username: $scope.username,
            Email: $scope.email,
            Password: $scope.password
        };

        var logindata = {
            LoginUsername: $scope.username,
            LoginEmail: $scope.email,
            LoginPassword: $scope.password,
            UserType: "Customer"
        };

        ajax.get(API_ROOT+"api/Login/"+$scope.username,success,error);
        function success(response){
            if(response.data == null){
                ajax.post(API_ROOT+"api/Login/Add",logindata,
            function(response){
                
                ajax.post(API_ROOT+"api/Customer/Add",customerdata,
            function(response){
                $scope.successMsg = "Registration was successful!";
            }
            ,function(error){
                $scope.errorMsg = "Email already exist!";
            });

            }
            ,function(error){
        
            });
            }else{
                $scope.errorMsg = "User already exist";
            }
            
        }
        function error(err){

            
        }



    }

});