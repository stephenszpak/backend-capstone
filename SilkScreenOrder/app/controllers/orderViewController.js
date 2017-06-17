app.controller("orderViewController", ["$scope", "$http", "$routeParams", "$location", function ($scope, $http, $routeParams, $location) {

    $scope.selectedOrder = [];
    let orderFormId = $routeParams.id;
    console.log("route params id", orderFormId);

 
    $http.get('api/orderform/details/' + $routeParams.id)
        .then(function (result) {
            $scope.selectedOrder = result.data;
            console.log("details maybes", result.data);
        });
    

    $scope.backToOrders = function () {
        $location.path("/orders");
    };

    $scope.deleteOrder = function () {
        $http.delete('api/orderform/' + $routeParams.id)
            .then(function (result) {
                console.log("deleted!", result);
                $location.path("/orders");
            });
    };


}]);