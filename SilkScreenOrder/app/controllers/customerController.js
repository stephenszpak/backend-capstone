app.controller("customerController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.customerList = [];

    $http.get('api/customer')
        .then(function (result) {
            console.log("get customers", result.data)
            $scope.customerList = result.data;
        });
}]);