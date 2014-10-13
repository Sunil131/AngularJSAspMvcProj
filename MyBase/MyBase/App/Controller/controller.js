forumsApp.controller('threadsController', function ($scope, $http, forumsAppService) {

    //$scope.threads = [
    //    { Header: 'Test1' },
    //    { Header: 'Test2' }
    //];


    //$scope.threads = forumsAppService.getThreads();


    //    $http.get("/app/GetThreads").
    //    success(function (data, status, headers, config) {
    //        $scope.threads = data;
    //    }).
    //error(function (data, status, headers, config) {
    //    alert('There is an Error Data: ' + data + " status " + status + " headers " + headers + " config " + config)
    //});
    $http({
        url: "/app/GetThreads",
        method: "GET"
    }).
    success(function (data, status, header, config) {
        $scope.threads = data.Threads;
        console.log(data);

    }).
    error(function (data, status, header, config) {
        alert(data + " " + error + " " + header + " " + config);
    });


});