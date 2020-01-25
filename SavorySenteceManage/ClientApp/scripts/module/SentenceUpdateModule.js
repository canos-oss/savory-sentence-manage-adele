function SentenceUpdateModule(SavorySenteceManageService, $convertor) {

    return {
        restrict: 'E',
        templateUrl: 'scripts/module/SentenceUpdateModule.html?v=' + window.releaseNo,
        replace: true,
        scope: {
            api: '='
        },
        link: function (scope, element, attrs) {

            scope.id = Number(attrs.id);

            function sentence_empty_callback(response, callback) {

                if (response.status != 1) {
                    return;
                }

                if (callback != null) {
                    callback();
                }
            }

            function sentence_basic_callback(response, callback) {

                scope.loaded = true;
                if (response.status != 1) {
                    return;
                }

                scope.item = response.item;

                if (callback != null) {
                    callback();
                }
            }

            function sentence_basic() {
                SavorySenteceManageService.sentence_basic({ id: scope.id }).then(function (response) {
                    sentence_basic_callback(response, sentence_assign)
                });
            }

            function sentence_assign() {
            }

            SavorySenteceManageService.sentence_empty({}).then(function (response) {
                sentence_empty_callback(response, sentence_basic);
            });

        },
        controller: function ($scope) {

            $scope.api = {};

            $scope.api.confirmUpdate = function (updateSuccessCallback) {

                $scope.waiting = true;
                $scope.message = null;

                var request = {};
                request.id = $scope.item.id;
                var requestItem = request.item = {};
                requestItem.content = $scope.item.content;

                SavorySenteceManageService.sentence_update(request).then(function (response) {
                    sentence_update_callback(response, updateSuccessCallback);
                });
            }

            function sentence_update_callback(response, updateSuccessCallback) {

                $scope.waiting = false;

                if (response.status != 1) {
                    $scope.message = response.message;
                    return;
                }

                if (updateSuccessCallback != null) {
                    updateSuccessCallback();
                }
            }
        }
    }
}
