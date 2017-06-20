app.controller("registrationController", ["$scope", "$http", "$location", function ($scope, $http, $location) {
    $scope.email = "";
    $scope.password = "";
    $scope.confirmPassword = "";

    $scope.signUp = function () {
        $http({
            method: 'POST',
            url: "/api/account/register",
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: { Email: $scope.email, Password: $scope.password, ConfirmPassword: $scope.confirmPassword }
        })
            .then(function (result) {
                console.log("result=", result);
                $location.path("/home");
            });
    }
}]);