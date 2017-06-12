app.controller("ordersController", ["$scope", "$http", "$q", function ($scope, $http, $q) {
    $scope.welcome = "yay it works";

    $scope.orderlist = [];

        //function getOrders() {
        //    return $q.all([
        //        $http.get('api/order'),
        //        $http.get('api/customer'),
        //        $http.get('api/design')
        //    ]).then(function (result) {
        //        console.log("maybe", result);
        //        $scope.orderlist = result;
        //        console.log("scope orderlist", $scope.orderlist);
        //       });
        //};

        //getOrders();


        $http.get('api/orderform')
            .then(function (result) {
                console.log("just api/order", result);
                $scope.orderlist = result.data;
            });

    //    $http.get('api/design')
    //        .then(function (result) {
    //            $scope.orderlist = result.data;
    //        });
    //    $http.get('api/apparel')
    //        .then(function (result) {
    //            $scope.orderlist = result.data;
    //        });
   

}]);