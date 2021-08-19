var Products;
var Product;
app.controller("CustomerHome",function($scope,$http,ajax,$location){
    ajax.get(API_ROOT+"api/Product/GetAll",success,error);
    function success(resp){
        $scope.products = resp.data;
        Products = $scope.products;
    }
    function error(err){

    }
    $scope.selectProduct = function(){
        ajax.get(API_ROOT+"api/Product/"+$scope.productId,succ,err);
        function succ(response){
            var product = response.data;
            Product = product;
            $scope.productPrice = product.ProductPrice + product.Menu.Price;
            $scope.productType = product.Type.TypeName;
            $scope.productFlavour = product.Menu.FlavourName;
            $scope.productCategory = product.Category;
        }
        function err(){

        }
    }

    $scope.buy = function(){
        var totalPrice = (Product.ProductPrice + Product.Menu.Price) * $scope.productQty + 100;
        var productBuy = {
            CustomerId: user.Id,
            DeliveryLocation: $scope.deliveryLocation,
            CustomerContactNumber: $scope.customerContactNumber,
            DeliveryDate: $scope.deliveryDate,
            ProductId: Product.Id,
            ProductQty: $scope.productQty,
            DeliveryCharge: 100,
            AdvancePaid: $scope.advancePaid,
            TotalPrice: totalPrice
        };
        ajax.post(API_ROOT+"api/Transaction/Add",productBuy,
            function(response){
                $scope.msg = "Thank you for your purchase!"
            }
            ,function(error){
        
            });
    }
});
