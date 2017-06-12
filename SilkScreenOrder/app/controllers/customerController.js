app.controller("customerController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
    
    $scope.customerlist = [];

    $http.get('api/customer')
    .then(function (result) {
        console.log("just api/customer", result);
        $scope.customerlist = result.data;
    });
}]);