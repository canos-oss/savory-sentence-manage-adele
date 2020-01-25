function SentenceCreateModule(SavorySenteceManageService, $convertor) {

    return {
        restrict: 'E',
        templateUrl: 'scripts/module/SentenceCreateModule.html?v=' + window.releaseNo,
        replace: true,
        scope: {
            api: '='
        },
        link: function (scope, element, attrs) {


            function sentence_empty_callback(response, callback) {

                if (response.status != 1) {
                    return;
                }

                if (callback != null) {
                    callback();
                }
            }

            //属性
            //_properties_event(builder, name, subject, subjectMap, metadataMap, cascadeMap, false);

            SavorySenteceManageService.sentence_empty({}).then(sentence_empty_callback);
        },
        controller: function ($scope) {

            //#region 【api】

            $scope.api = {};

            $scope.api.confirmCreate = function (createSuccessCallback) {

                $scope.waiting = true;
                $scope.message = null;

                var request = {};
                var requestItem = request.item = {};
                requestItem.content = $scope.item.content;

                SavorySenteceManageService.sentence_create(request).then(function (response) {
                    sentence_create_callback(response, createSuccessCallback)
                });
            }

            //#endregion 【api】

            //#region 【callback】

            function sentence_create_callback(response, createSuccessCallback) {

                $scope.waiting = false;

                if (response.status != 1) {
                    $scope.message = response.message;
                    return;
                }

                if (createSuccessCallback != null) {
                    createSuccessCallback();
                }
            }

            //#endregion 【callback】
        }
    }
}
