/*************************** eventAppController.js *********************************/
(function () {
    "use strict";

    angular
        .module("eventApp")
        .controller("eventController", eventController);


    function eventController($http, $sce, $scope) {
        var vm = this;
        vm.events = [];
        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/events")
            .then(function (response) {
                angular.copy(response.data, vm.events);
            },
                function (e) {
                    vm.errorMessage = "Unable to load events " + e.message;
                })
            .finally(function () {
                vm.isBusy = false;
            });


        $scope.select = function (item) {
            var newItem = {};
            newItem.title = item.title;
            newItem.eventHtml = $sce.trustAsHtml(item.eventHtml);
            $scope.selected = newItem;
        };
        $scope.selected = {};

        


        //vm.pager = { };
        //vm.setPage = setPage;
        //initController();
        //function initController() {
        //    vm.setPage(1);
        //}


        //function setPage(page) {
        //    if (page < 1 || page > vm.pager.totalPages) {
        //        return;
        //    }
        //    vm.pager = pagerService.GetPager(vm.events.length, page);
        //    vm.items = vm.events.slice(vm.pager.startIndex, vm.pager.endIndex + 1);
        //}
    }

})();


