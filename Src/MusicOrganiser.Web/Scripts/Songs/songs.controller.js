'use strict';

angular.module('app', ['ngResource'])

    .controller('songs', ['$scope', '$resource', function ($scope, $resource) {
        $scope.bob = "Bob Bobson";

        var songsResource = $resource('/api/songs/:id', { id: '@id' });

        $scope.allSongs = songsResource.query(function (allSongs) {
            //$scope.allSongs = allSongs;
        });


        //var realSongs = songsResource.get({ id: 2 }, function () {
        //    user.abc = true;
        //    user.$save();
        //});

        //ngResource
        //var User = $resource('/user/:userId', { userId: '@id' });
        //var user = User.get({ userId: 123 }, function () {
        //    user.abc = true;
        //    user.$save();
        //});

        //eating an 'update' method
        //app.factory('Notes', ['$resource', function($resource) {
        //    return $resource('/notes/:id', null,
        //        {
        //            'update': { method:'PUT' }
        //        });
        //}]);


    }])
