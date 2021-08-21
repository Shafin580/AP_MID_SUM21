app.controller("AdminAddProduct",function($scope,$http,ajax,$location){
    ajax.get(API_ROOT+"api/Menu/GetAll",suc,err);
    function suc(response){
        $scope.menus = response.data;
    }
    function err(){

    }
    ajax.get(API_ROOT+"api/Type/GetAll",succ,erro);
    function succ(response){
        $scope.types = response.data;
    }
    function erro(){
        
    }
    var hasError;
    function prductNameValidation(name){
        if(name===""){
            $scope.nameError = "Name can't be empty";
            hasError = true;
        }
    }
    function priceValidation(price){
        if(price===""){
            $scope.priceError = "Price can't be empty";
            hasError = true;
        }
    }
    function typeValidation(type){
        if(type===""){
            $scope.typeError = "Type can't be empty";
            hasError = true;
        }
    }
    function productDetailValidation(detail){
        if(detail===""){
            $scope.detailError = "Detail can't be empty";
            hasError = true;
        }
    }
    function flavourValidation(flavour){
        if(flavour===""){
            $scope.flavourError = "Flavour can't be empty";
            hasError = true;
        }
    }
    function categoryValidation(category){
        if(category===""){
            $scope.categoryError = "Category can't be empty";
            hasError = true;
        }
    }
    $scope.add = function(){
        $scope.nameError = "";
        $scope.priceError = "";
        $scope.typeError = "";
        $scope.detailError = "";
        $scope.flavourError = "";
        $scope.categoryError = "";
        hasError = false;
        prductNameValidation($scope.name);
        priceValidation($scope.price);
        typeValidation($scope.type);
        productDetailValidation($scope.detail);
        flavourValidation($scope.flavour);
        categoryValidation($scope.category);

        if(!hasError){
            var productdata = {
                ProductName: $scope.name,
                ProductPrice: $scope.price,
                TypeId: $scope.type,
                ProductDetail: $scope.detail,
                FlavourId: $scope.flavour,
                Category: $scope.category
            };
    
            ajax.post(API_ROOT+"api/Product/Add",productdata,
            function(response){
                $scope.successMsg = "Product Added Successfully";
                $location.path('/AdminMenu');
            },
            function(error){});
        }

    }

});