function SentenceItemModule(SavorySenteceManageService) {

    return {
        restrict: 'E',
        templateUrl: 'scripts/module/SentenceItemModule.html?v=' + window.releaseNo,
        replace: true,
        scope: {},
        link: function (scope, element, attrs) {

            scope.id = Number(attrs.id);


            //#region 【callback】

            function sentence_item_callback(response) {

                scope.loaded = true;
                if (response.status != 1) {
                    return;
                }

                scope.item = response.item;
            }

            //#endregion 【callback】

            {
                var request = {};
                request.id = scope.id;

                SavorySenteceManageService.sentence_item(request).then(sentence_item_callback);
            }
        }
    }
}
