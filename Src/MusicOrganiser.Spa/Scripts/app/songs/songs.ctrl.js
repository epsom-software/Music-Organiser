'use strict';

angular.module('app.songs')
//window.mike.appSongs

    // Path: /songs
    .controller('SongsCtrl', ['$scope', '$location', '$window', 'songsResource', function ($scope, $location, $window, songsResource) {
        $scope.$root.title = 'Songs and stuff';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.allSongs = songsResource.query();
    }])
