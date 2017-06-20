app.controller("orderFormController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.newOrder = {};

    $scope.submitOrder = function (order) {  
        $http.post('api/orderform', order)
            .then(function (result) {
                console.log(result);
                $location.path("/orders");
            });
    };

    //Converts undefined to 0 or the number in the input
    function ensureNumber(num) {
        return num ? num : 0;
    }

    $scope.recalculate = function () {
        if ($scope.newOrder.ApparelQuantity > 10)
        {
            $scope.newOrder.TotalPrice =
                (ensureNumber($scope.newOrder.ApparelQuantity) * ensureNumber($scope.newOrder.ApparelPricePerPiece))
                + (ensureNumber($scope.newOrder.ApparelQuantity) * ensureNumber($scope.newOrder.PrintingFee))
                + ensureNumber($scope.newOrder.DesignFee);
        }
        else if($scope.newOrder.ApparelQuantity < 10)
        {
            $scope.newOrder.TotalPrice = ensureNumber($scope.newOrder.ApparelQuantity)
                * ensureNumber($scope.newOrder.ApparelPricePerPiece)
                + ensureNumber($scope.newOrder.PrintingFee)
                + ensureNumber($scope.newOrder.DesignFee);
        }
    }
}]);