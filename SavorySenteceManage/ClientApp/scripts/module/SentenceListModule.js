function SentenceListModule(SavorySenteceManageService, $uibModal) {

    return {
        restrict: 'E',
        templateUrl: 'scripts/module/SentenceListModule.html?v=' + window.releaseNo,
        replace: true,
        scope: {},
        link: function (scope, element, attrs) {


            //#region 【callback】

            function sentence_items_callback(response) {

                scope.items_loaded = true;
                if (response.status != 1) {
                    scope.items_message = response.message;
                    return;
                }

                scope.items = response.items;
            }

            function sentence_count_callback(response) {

                scope.count_loaded = true;
                if (response.status != 1) {
                    scope.count_message = response.message;
                    return;
                }

                scope.totalCount = response.totalCount;
            }

            function sentence_disable_callback(response) {

                if (response.status != 1) {
                    return;
                }

                scope.pageChanged();
            }

            //#endregion 【callback】

            scope.openCreate = function () {

                var modalInstance = $uibModal.open({
                    size: 'lg',
                    animation: true,
                    backdrop: 'static',
                    templateUrl: 'scripts/modal/SentenceCreateModal.html?v=' + window.releaseNo,
                    controller: SentenceCreateModal,
                    resolve: {
                    }
                });

                modalInstance.result.then(function (response) {
                    scope.refresh();
                }, function () {
                });
            }

            scope.openItem = function (id) {

                var modalInstance = $uibModal.open({
                    size: 'lg',
                    animation: true,
                    backdrop: 'static',
                    templateUrl: 'scripts/modal/sentenceItemModal.html?v=' + window.releaseNo,
                    controller: SentenceItemModal,
                    resolve: {
                        id: function () { return id; }
                    }
                });

                modalInstance.result.then(function (response) { }, function () { });
            }

            scope.openUpdate = function (id) {

                var modalInstance = $uibModal.open({
                    size: 'lg',
                    animation: true,
                    backdrop: 'static',
                    templateUrl: 'scripts/modal/SentenceUpdateModal.html?v=' + window.releaseNo,
                    controller: SentenceUpdateModal,
                    resolve: {
                        id: function () { return id; }
                    }
                });

                modalInstance.result.then(function (response) {
                    scope.refresh();
                }, function () {
                });
            }

            scope.pageChanged = function () {

                scope.items_loaded = false;
                scope.items_message = null;

                var request = {};
                request.pageIndex = scope.currentPage;

                SavorySenteceManageService.sentence_items(request).then(sentence_items_callback);
            }

            scope.disable = function (id) {

                SavorySenteceManageService.sentence_disable({ id: id }).then(sentence_disable_callback);
            }

            scope.refresh = function () {

                {
                    var request = {};
                    SavorySenteceManageService.sentence_count(request).then(sentence_count_callback);
                }

                {
                    var request = {};
                    request.pageIndex = scope.currentPage;
                    SavorySenteceManageService.sentence_items(request).then(sentence_items_callback);
                }
            }

            {
                scope.maxSize = 10;
                scope.currentPage = 1;
                scope.pageSize = 20;

                scope.refresh();
            }
        }
    }
}
