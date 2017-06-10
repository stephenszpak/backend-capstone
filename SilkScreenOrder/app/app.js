var app = angular.module("SilkScreen", ["ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when("/orders", {
            templateUrl: "app/partials/orders.html",
            controller: "ordersController"
        })
        .when("/orderform", {
            templateUrl: "app/partials/orderform.html",
            controller: "orderFormController"
        })
        //.when("/order/details/:id", {
        //    templateUrl: "app/partials/details.html",
        //    controller: "detailController"
        //})
    }
])