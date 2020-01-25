//Module
var app = angular.module('app', ['ngResource', 'ui.router', 'ui.bootstrap', 'ui.sortable', 'ngCanos']);

//Config
app.factory(httpInterceptor);
app.config(httpProviderConfig);
app.config(stateProviderConfig);
app.config(urlRouterProviderConfig);

//Directive
app.directive('sentenceListModule', SentenceListModule);
app.directive('sentenceItemModule', SentenceItemModule);
app.directive('sentenceCreateModule', SentenceCreateModule);
app.directive('sentenceUpdateModule', SentenceUpdateModule);

//service
app.service('SavorySenteceManageService', ['$resource', '$q', '$state', SavorySenteceManageService]);
