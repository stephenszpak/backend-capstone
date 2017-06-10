app.controller("ordersController", ["$scope", "$http", "$q", function ($scope, $http, $q) {
    $scope.welcome = "yay it works";

    $scope.orderlist = [];


    //var order = $http.get('api/order'),
    //    customer = $http.get('api/customer'),
    //    design = $http.get('api/customer'),
    //    apparel = $http.get('api/apparel');

    //$q.all([order, customer, design, apparel])
    //    .then(function (arrayOfResults) {
    //        $scope.orderlist = arrayOfResults.data;
    //    });


    function getOrders() {
        return $q.all([
            $http.get('api/order'),
            $http.get('api/customer'),
            $http.get('api/design')
        ]).then(function (result) {
            console.log("maybe", result);
            $scope.orderlist = result;
            console.log("maybe", $scope.orderlist);
           });
    };

    getOrders();

    //function getCustomers(){
    //    $http.get('api/customer')
    //        .then(function (result) {
    //            $scope.orderlist = result.data;
    //        });
    //};

    //function getDesigns(){
    //    $http.get('api/design')
    //        .then(function (result) {
    //            $scope.orderlist = result.data;
    //        });
    //};

    //function getApparel() {
    //    $http.get('api/apparel')
    //        .then(function (result) {
    //            $scope.orderlist = result.data;
    //        });
    //};
}]);