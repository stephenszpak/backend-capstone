var app = angular.module("SilkScreen", ["ngRoute"]);

app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "/app/partials/home.html",
            controller: "homeController"
        })
        .when("/orders", {
            templateUrl: "/app/partials/orders.html",
            controller: "ordersController"
        })
        .when("/orderdetail/:id", {
            templateUrl: "/app/partials/orderdetails.html",
            controller: "orderViewController"
        })
        .when("/orderform", {
            templateUrl: "/app/partials/orderform.html",
            controller: "orderFormController"
        });
}
]);