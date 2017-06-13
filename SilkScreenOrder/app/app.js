var app = angular.module("SilkScreen", ["ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "app/partials/home.html",
            controller: "homeController"
        })
        .when("/orders", {
            templateUrl: "app/partials/orders.html",
            controller: "ordersController"
        })
        .when("/orders/details/:id", {
            templateUrl: "app/partials/orderdetails.html",
            controller: "orderViewController"
        })
        .when("/orderform", {
            templateUrl: "app/partials/orderform.html",
            controller: "orderFormController"
        })
        .when("/design", {
            templateUrl: "app/partials/design.html",
            controller: "designController"
        })
        .when("/apparel", {
            templateUrl: "app/partials/apparel.html",
            controller: "apparelController"
        })
        .when("/customer", {
            templateUrl: "app/partials/customer.html",
            controller: "customerController"
        })
    }
])