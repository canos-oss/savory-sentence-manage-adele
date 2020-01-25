function SentenceListModal($scope, $uibModalInstance) {

    $scope.closeModal = function () {
        $uibModalInstance.dismiss("cancel");
    }
}
