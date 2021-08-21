app.controller("AdminProfile",function($scope,$http,ajax,$location){
    ajax.get(API_ROOT+"api/Admin/"+user.Username,success,error);
    function success(response){
        var userData = response.data;
        $scope.id = userData.Id;
        $scope.name = userData.Name;
        $scope.username = userData.Username;
        $scope.email = userData.Email;
        $scope.password = userData.Password;
    }
    function error(error){

    }

    var hasError;
    function nameValidation(name){
        if(name===""){
            $scope.nameError = "Name can't be empty";
            hasError = true;
        }
        else if(String(name).split(" ").length < 2){
            $scope.nameError = "Must contain atleast 2 words!";
            hasError = true;
        }
    }
    function passwordValidation(password){
        if(password===""){
            $scope.passwordError = "Password can't be empty";
            hasError = true;
        }
        else if(String(password).split(" ").length > 1){
            $scope.passwordError = "Can not contain space!";
            hasError = true;
        }
    }
    function emailValidation(email){
        if(email===""){
            $scope.emailError = "Email can't be empty";
            hasError = true;
        }
        else if(String(email).split(" ").length > 1){
            $scope.emailError = "Invalid email!";
            hasError = true;
        }
        else if(String(email).includes("@")==false){
            $scope.emailError = "Invalid email!";
            hasError = true;
        }
    }

    $scope.update = function(){
        $scope.nameError = "";
        $scope.passwordError = "";
        $scope.emailError = "";
        $scope.phoneNumberError = "";
        hasError = false;
        nameValidation($scope.name);
        emailValidation($scope.email);
        passwordValidation($scope.password);

        if(!hasError){
            var data = {
                Id: $scope.id,
                Name: $scope.name,
                Username: $scope.username,
                Email: $scope.email,
                Password: $scope.password
            };
    
            ajax.post(API_ROOT+"api/Admin/"+$scope.username+"/Edit",data,
            function(response){
                $scope.msg = "Profile updated successfully!"
            },
            function(error){
    
            });
        }       
    }
});