app.controller("AdminAddFlavour",function($scope,$http,ajax,$location){
    var hasError;
    function flavourNameValidation(name){
        if(name===""){
            $scope.nameError = "Flavour name can't be empty";
            hasError = true;
        }
    }
    function priceValidation(price){
        if(price===""){
            $scope.priceError = "Price can't be empty";
            hasError = true;
        }
    }
    function flavourDetailValidation(detail){
        if(detail===""){
            $scope.detailError = "Detail can't be empty";
            hasError = true;
        }
    }
    $scope.add = function(){
        $scope.nameError = "";
        $scope.priceError = "";
        $scope.detailError = "";
        hasError = false;
        flavourNameValidation($scope.name);
        priceValidation($scope.price);
        flavourDetailValidation($scope.detail);

        if(!hasError){
            var flavourdata = {
                FlavourName: $scope.name,
                FlavourDetail: $scope.detail,
                Price: $scope.price
            };
    
            ajax.post(API_ROOT+"api/Menu/Add",flavourdata,
            function(response){
                $scope.successMsg = "New Flavour Added Successfully";
                $location.path('/AdminMenu');
            },
            function(error){});
        }

    }

});