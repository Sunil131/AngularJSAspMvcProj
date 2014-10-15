var forumsApp = angular.module('forumsApp', ['ngRoute']);

forumsApp.config(function ($routeProvider) {
    $routeProvider
        .when('/newThread', {
            controller: 'threadsController',
            templateUrl: '../App/Partials/AddNewThread.html'
        })
        .when('/newPost', {
            controller: 'postController',
            templateUrl: '../App/Partials/AddNewPost.html'
        }
        )
        .when('/', {
            controller: 'threadsController',
            templateUrl: '../App/Partials/AddNewThread.html'

        }
        );
  // $routeProvider.otherwise({ redirectTo: "/explore" });
    

});


