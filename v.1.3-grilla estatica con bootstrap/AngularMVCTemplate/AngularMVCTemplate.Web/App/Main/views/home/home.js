(function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, ['$scope', '$http', function ($scope, $http) {
        var vm = this;

        $scope.theData = [
            {
                id: 1,
                name: "Moroni",
                allowance: 505050505050505050,
                paid: true
            },
            {
                id: 2,
                name: "Tiancum",
                allowance: 53,
                paid: false
            },
            {
                id: 3,
                name: "Tiancum",
                allowance: 53,
                paid: false
            },
            {
                id: 4,
                name: "Tiancum",
                allowance: 53,
                paid: false
            },
            {
                id: 5,
                name: "Tiancum",
                allowance: 53,
                paid: false
            }];


        /*$scope.filterOptions = {
            filterText: "",
            useExternalFilter: true
        };
        $scope.totalServerItems = 0;
        $scope.pagingOptions = {
            pageSizes: [250, 500, 1000],
            pageSize: 250,
            currentPage: 1
        };
        $scope.setPagingData = function (data, page, pageSize) {
            var pagedData = data.slice((page - 1) * pageSize, page * pageSize);
            $scope.myData = pagedData;
            $scope.totalServerItems = data.length;
            if (!$scope.$$phase) {
                $scope.$apply();
            }
        };
        $scope.getPagedDataAsync = function (pageSize, page, searchText) {
            setTimeout(function () {
                var data;
                if (searchText) {
                    var ft = searchText.toLowerCase();
                    
                    data = theData.filter(function (item) {
                        return JSON.stringify(item).toLowerCase().indexOf(ft) != -1;
                    });
                    $scope.setPagingData(data, page, pageSize);
                    
                } else {                    
                    $scope.setPagingData($scope.theData, page, pageSize);                    
                }
            }, 100);
        };
        $scope.getPagedDataAsync($scope.pagingOptions.pageSize, $scope.pagingOptions.currentPage);
        $scope.$watch('pagingOptions', function (newVal, oldVal) {
            if (newVal !== oldVal && newVal.currentPage !== oldVal.currentPage) {
                $scope.getPagedDataAsync($scope.pagingOptions.pageSize, $scope.pagingOptions.currentPage, $scope.filterOptions.filterText);
            }
        }, true);
        $scope.$watch('filterOptions', function (newVal, oldVal) {
            if (newVal !== oldVal) {
                $scope.getPagedDataAsync($scope.pagingOptions.pageSize, $scope.pagingOptions.currentPage, $scope.filterOptions.filterText);
            }
        }, true);
        $scope.gridOptions = {
            data: 'myData',
            enablePaging: true,
            showFooter: true,
            totalServerItems: 'totalServerItems',
            pagingOptions: $scope.pagingOptions,
            filterOptions: $scope.filterOptions
        };*/

        //$scope.sortBy = function (array) {

            /*var newArray = [];
            newArray.push(array);
            console.log(newArray);*/

            /*var result = _.pickBy(array, function (value, key) {
                return _.startsWith(key, "a");
            });
            console.log(result);
        }*/
        
    }]);
})();