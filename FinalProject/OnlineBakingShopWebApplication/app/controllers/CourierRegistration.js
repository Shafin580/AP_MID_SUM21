app.controller("CourierRegistration",function($scope,$http,ajax,$location){
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
    function usernameValidation(username){
        if(username===""){
            $scope.usernameError = "Username can't be empty";
            hasError = true;
        }
        else if(String(username).split(" ").length > 1){
            $scope.usernameError = "Can not contain space!";
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
    function phoneNumberValidation(phoneNumber){
        if(phoneNumber===""){
            $scope.phoneNumberError = "Phone Number can't be empty";
            hasError = true;
        }
        else if(String(phoneNumber).length != 10){
            $scope.phoneNumberError = "Invalid Phone Number";
            hasError = true;
        }
    }
    function nidValidation(nid){
        if(nid===""){
            $scope.nidError = "NID can't be empty";
            hasError = true;
        }
        else if(String(nid).length != 13){
            $scope.nidError = "Invalid NID";
            hasError = true;
        }
    }
    $scope.register = function(){
        $scope.nameError = "";
        $scope.usernameError = "";
        $scope.passwordError = "";
        $scope.emailError = "";
        $scope.phoneNumberError = "";
        $scope.nidError = "";
        hasError = false;
        nameValidation($scope.name);
        usernameValidation($scope.username);
        emailValidation($scope.email);
        passwordValidation($scope.password);
        phoneNumberValidation($scope.phonenumber);
        nidValidation($scope.nid);

        if(!hasError){
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

    }

});