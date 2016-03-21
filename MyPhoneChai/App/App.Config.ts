﻿module App
{
    export class AppConfig
    {
        private stateProvider: angular.ui.IStateProvider;
        private urlProvider: angular.ui.IUrlRouterProvider;

        static $inject = ["$stateProvider", "$urlRouterProvider"];
        constructor($stateProvider: angular.ui.IStateProvider, $urlRouterProvider: angular.ui.IUrlRouterProvider)
        {
            this.stateProvider = $stateProvider;
            this.urlProvider = $urlRouterProvider;

            $stateProvider.
                state("root", {
                                  url: "",
                                  abstract: true,
                                  template: " < div ui-view class=\"container-fluid slide\"></div>",
                             }
                )
                .state("root.home", {
                    url: "/",
                    templateUrl: "partials/home/home.tpl.html",
                    controller: "HomeController",
                    controllerAs: "vm"
                })
                .state("root.signin",
                {
                    url: "/signin",
                    templateUrl: "partials/account/signin.tpl.html"
                })
                .state("root.phone-entry", {
                    url: "/phone-entry",
                    templateUrl: "partials/phone/phone-entry.tpl.html",
                    controller: "PhoneController",
                    controllerAs: "vm"
                }).state("root.phone-edit", {
                    url: "/phone-edit/:id",
                    templateUrl: "partials/phone/phone-entry.tpl.html",
                    controller: "PhoneController",
                    controllerAs: "vm"
                })
                .state("root.phone-list", {
                    url: "/phone-list",
                    templateUrl: "partials/phone/phone-list.tpl.html",
                    controller: "PhoneQueryController",
                    controllerAs: "vm"
                });
        }
               
    }
    angular.module("app", ["ui.router", "ngResource"]);
    angular.module("app").config(AppConfig);
}