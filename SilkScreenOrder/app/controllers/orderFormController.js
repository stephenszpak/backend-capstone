app.controller("orderFormController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.newOrder = {};

    $scope.submitOrder = function (order) {
        $http.post('api/orderform', order)
            .then(function (result) {
                console.log(result);
                $location.path("/orders");
            });
    };

    $scope.submitDesign = function (design) {
        $http.post('api/design', design)
            .then(function (result) {
                console.log("design", result);
            });
    };

    $scope.submitCustomer = function (customer) {
        $http.post('api/customer', customer)
            .then(function (result) {
                console.log("customer", result);
            });
    };

    $scope.submitApparel = function (apparel) {
        $http.post('api/apparel', apparel)
            .then(function (result) {
                console.log("appare;", result);
                $location('design');
            });
    };

}]);