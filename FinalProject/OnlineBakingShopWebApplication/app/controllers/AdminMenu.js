app.controller("AdminMenu",function($scope,$http,ajax){
    ajax.get(API_ROOT+"api/Product/GetAll",success,error);
    function success(response) {
        $scope.products = response.data;
    }
    function error(error) {

    }

    ajax.get(API_ROOT+"api/Menu/GetAll",suc,err);
    function suc(response) {
        $scope.flavours = response.data;
    }
    function err(error) {

    }

    $scope.add = function(){
        var typedata = {
            TypeName: $scope.name
        };

        ajax.post(API_ROOT+"api/Type/Add",typedata,
            function(response){
                $scope.msg = "Type Added Successfully";
            },
            function(error){});

            $scope.name = "";
    }
});