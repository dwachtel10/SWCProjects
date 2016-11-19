var myApp = angular.module('friendsApp', ['ngRoute']);

myApp.factory('friendsFactory',
    function($http) {
        //create a new object
        var webAPIProvider = {};
        //url of our WebAPI controller
        var url = '/api/friends/';
        //add method to get all friends
        webAPIProvider.getFriends = function() {
            return $http.get(url);
        };

        // add a method to add a friend
        webAPIProvider.saveFriend = function(friend) {
            return $http.post(url, friend);
        };

        // return wrapped API object
        return webAPIProvider;

    });

myApp.config(function($routeProvider) {
    $routeProvider.when('/Routes',
        {
            controller: 'FriendsController',
            templateUrl: '/AngularViews/FriendList.html'
        })
        .when('/AddFriend',
        {
            controller: 'AddFriendController',
            templateUrl: '/AngularViews/AddFriend.html'
        })
        .otherwise({ redirectTo: '/Routes' });
});

myApp.controller('FriendsController',
    function($scope, friendsFactory) {
        friendsFactory.getFriends()
            .success(function(data) {
                $scope.getFriends = data;
            })
            .error(function(data, status) {
                alert('Uh oh! Status: ' + status);
            });
    }
);

myApp.controller('AddFriendController',
    function ($scope, $location, friendsFactory) {
        $scope.getFriends = {};

        $scope.save = function() {
            friendsFactory.saveFriend($scope.friend)
                .success(function() {
                    $location.path('/Routes');
                })
                .error(function(data, status) {
                    alert('Uh oh! Status: ' + status);
                });
        };

    });