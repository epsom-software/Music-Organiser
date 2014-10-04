'use strict';

angular.module('app.songs')
//window.mike.appSongs

    .factory('songsResource', ['$resource', function ($resource) {

        //var songsResource = $resource('http://music-organiser/api/songs/', { id: '@id' });
        //var songsResource = $resource('http://music-organiser/api/songs/:id', { id: '@id' });
        //return songsResource.query();

        //return ["hello", "service"]


        return $resource('http://music-organiser/api/songs/:id', { id: '@id' });

    }])
