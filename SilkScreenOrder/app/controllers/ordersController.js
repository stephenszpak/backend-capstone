app.controller("ordersController", ["$scope", "$http", "$routeParams", function ($scope, $http, $routeParams) {
    $scope.welcome = "yay it works";

    $scope.orderlist = [];

    $http.get('api/orderform')
        .then(function (result) {
            console.log("just api/order", result);
            $scope.orderlist = result.data;
        });
}]);