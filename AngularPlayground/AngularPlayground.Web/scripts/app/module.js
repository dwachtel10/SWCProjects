var myApp = angular.module('demoApp', []);

myApp.controller('SimpleController',
    function($scope) {
        $scope.players = [
            { name: 'Jason Kipniss', pos: '2B' },
            { name: 'Francisco Lindor', pos: 'SS' },
            { name: 'Carlos Santana', pos: 'DH' }
        ];

    });