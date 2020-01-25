function SentenceCreatePage($scope, $state) {

    $scope.confirmCreate = function () {
        if ($scope.api == null) {
            return;
        }
        if ($scope.api.confirmCreate == null) {
            return;
        }
        $scope.api.confirmCreate(function () {
            $state.go('app.layout.default.sentence-list');
        });
    }
}
