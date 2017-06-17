app.controller("customerController", ["$scope", "$http", "$location", "$routeParams", function ($scope, $http, $location, $routeParams) {
    
    $scope.customerlist = [];

    $http.get('api/customer')
    .then(function (result) {
        console.log("just api/customer", result);
        $scope.customerlist = result.data;
    });

    $scope.deleteCustomer = function () {
        $http.delete('api/customer/{CustomerId}')
            .then(function (result) {
                console.log("deleted customer!", result);
            });
    };
}]);