app.controller("homeController", ["$scope", "$http", "$location", function ($scope, $http, $location) {


    $scope.startOrder = function () {
        $location.path("/orderform");
    };

}]);