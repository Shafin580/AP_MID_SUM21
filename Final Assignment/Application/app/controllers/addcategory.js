app.controller("addcategory",function($scope,ajax){

    $scope.addcategory = function(){
        var c = {
            id: 0,
            name: $scope.name
        };
    }
    ajax.post(API_ROOT+"/api/Category/Add",c,
    function(response){

    }
    ,function(error){

    });
    
});