app.controller("CustomerProfile",function($scope,$http,ajax,$location){
    ajax.get(API_ROOT+"api/Customer/"+user.Username,success,error);
    function success(response){
        var userData = response.data;
        $scope.id = userData.Id;
        $scope.name = userData.Name;
        $scope.username = userData.Username;
        $scope.email = userData.Email;
        $scope.password = userData.Password;
        $scope.phoneNumber = userData.PhoneNumber;
    }
    function error(error){

    }

    $scope.update = function(){
        var data = {
            Id: $scope.id,
            Name: $scope.name,
            Username: $scope.username,
            Email: $scope.email,
            Password: $scope.password,
            PhoneNumber: $scope.phoneNumber
        };

        ajax.post(API_ROOT+"api/Customer/"+$scope.username+"/Edit",data,
        function(response){
            $scope.msg = "Profile updated successfully!"
        },
        function(error){

        });
    }
});