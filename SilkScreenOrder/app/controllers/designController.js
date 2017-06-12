app.controller("designController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.designlist = [];

    $http.get('api/design')
    .then(function (result) {
        console.log("just api/customer", result);
        $scope.designlist = result.data;
    });

}]);