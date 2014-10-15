forumsApp.controller('threadsController', function ($scope, $http, $location,forumsAppService) {

  $http.get("/app/GetThreads").
        success(function (data, status, headers, config) {
            $scope.threads = data;
            console.log(data);
        }).
    error(function (data, status, headers, config) {
        alert('There is an Error Data: ' + data + " status " + status + " headers " + headers + " config " + config)
    });

    /////////////////Below Is Approch 2//////////////////////////////////////////
    //$http({
    //    url: "/app/GetThreads",
    //    method: "GET"
    //}).
    //success(function (data, status, header, config) {
    //    $scope.threads = data.Threads;
    //    console.log(data);

    //}).
    //error(function (data, status, header, config) {
    //    alert(data + " " + error + " " + header + " " + config);
    //});

    //////////////////////Approach Ends Here///////////////////////////////////////

  $scope.submitThread = function() {
      $scope.threads.push({ CreatedBy: 0, Header: $scope.newThread.Header, CreatedOn: Date.now, FirstPostId: 0, IsActive: true, ThreadPosts: {}, ID: 0 });
      $location.path("/newPost")
  }
    

});

forumsApp.controller('postController', function ($scope) {

    $scope.submitNewThreadwithPost = function () {
        alert('its working, Start adding code for adding a post here with AJAX.');
        //write a post code for new thread with a post
    }

})