app.controller("orderFormController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.newOrder = {
        CustomerName: "",
        CustomerAddress: "",
        NumberOfColors: "",
        DesignFee: "",
        NumberOfItems: "",
        ApparelBrand: "",
        OrderDate: "",
        DueDate: ""
    };

    
    $scope.submitCustomer = function (customer) {
        $http.post('api/customer', customer)
            .then(function (result) {
                console.log("customer", result);
            });
    };


    $scope.submitApparel = function (apparel) {
        $http.post('api/apparel', apparel)
            .then(function (result) {
                console.log("appare;", result);
            });
    };

    $scope.submitDesign = function (design) {
        $http.post('api/design', design)
            .then(function (result) {
                console.log("design", result);
            });
    };

    $scope.submitOrder = function (order) {
        $http.post('api/order', order)
            .then(function (result) {
                console.log(result);
                $location.path("/orders");

            });
    };
}]);