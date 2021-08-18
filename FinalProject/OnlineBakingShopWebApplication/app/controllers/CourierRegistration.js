app.controller("CourierRegistration",function($scope,$http,ajax,$location){
    
    $scope.register = function(){
        var courierdata = {
            name: $scope.name,
            Username: $scope.username,
            Email: $scope.email,
            Password: $scope.password,
            PhoneNumber: $scope.phonenumber,
            NID: $scope.nid
        };

        var logindata = {
            LoginUsername: $scope.username,
            LoginEmail: $scope.email,
            LoginPassword: $scope.password,
            UserType: "Courier"
        };

        ajax.get(API_ROOT+"api/Login/"+$scope.username,success,error);
        function success(response){
            if(response.data == null){
                ajax.post(API_ROOT+"api/Login/Add",logindata,
            function(response){
                
                ajax.post(API_ROOT+"api/Courier/Add",courierdata,
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