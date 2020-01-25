function stateProviderConfig($stateProvider) {

    $stateProvider.state('app', { url: '/', template: '<ui-view></ui-view>' });

    $stateProvider.state('app.layout', {
        templateUrl: 'scripts/view/view_layout.html?v=' + window.releaseNo
    });

    $stateProvider.state('app.layout.default', {
        views: {
            'header': { templateUrl: 'scripts/view/view_header.html?v=' + window.releaseNo, controller: HeaderController },
            'main-menu': { templateUrl: 'scripts/view/view_menu.html?v=' + window.releaseNo },
            'main-body': { template: '<ui-view></ui-view>' }
        }
    });

    $stateProvider.state('app.layout.default.welcome', { url: 'welcome', templateUrl: 'scripts/view/view_welcome.html?v=' + window.releaseNo });

    $stateProvider.state('app.layout.default.sentence-list', { url: 'sentence-list', templateUrl: 'scripts/page/SentenceListPage.html?v=' + window.releaseNo, controller: SentenceListPage });

    $stateProvider.state('app.otherwise', {
        url: '*path',
        templateUrl: 'views/view_404.html?v=' + window.releaseNo
    });
}