app.controller("addcategory",function($scope,ajax,$location){

    $scope.addcategory = function(){
        var c = {
            name: $scope.name
        };
        ajax.post(API_ROOT+"/api/Category/Add",c,
    function(response){
        $location.path("/category");
    }
    ,function(error){

    });

    }
    
    
});