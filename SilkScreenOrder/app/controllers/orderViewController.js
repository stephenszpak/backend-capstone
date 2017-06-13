app.controller("orderViewController", ["$scope", "$http", "$routeParams", function ($scope, $http, $routeParams) {

    $scope.selectedOrder = [];
    let orderFormId = $routeParams.id;
    console.log("route params", orderId)

    $http.get('api/orderform/details/{OrderFormId}')
        .then(function (oneOrder) {
            oneOrder.id = orderFormId;
            $scope.selectedOrder = oneOrder;
        });

}]);