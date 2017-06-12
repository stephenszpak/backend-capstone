app.controller("apparelController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.apparel = {};

    $scope.submitApparel = function (apparel) {
        $http.post('api/apparel', apparel)
            .then(function (result) {
                console.log("appare;", result);
                $location('design');
            });
    };

}]);