app.controller("addproduct",function($scope,$http,ajax,$location){
    ajax.get(API_ROOT+"/api/Category/GetAll",
    function(resp){
        $scope.category = resp.data;
    },
    function(error){
    });
    $scope.addproduct = function(){
        var p = {
            name: $scope.name,
            category_id: $scope.catId,
            price: $scope.price,
            qty: $scope.qty,
            description: $scope.desc
        };
        ajax.post(API_ROOT+"/api/Product/Add",p,
    function(response){
        $location.path("/product");
    }
    ,function(error){

    });

    }
});