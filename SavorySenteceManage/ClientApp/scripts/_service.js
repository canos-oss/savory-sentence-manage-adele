function SavorySenteceManageService($resource, $q, $state) {

    function process(result, d){
        if (result.status == 401) {
            localStorage["token"] = "";
            $state.go('app.login', {});
        } else {
            d.reject(result);
        }
    }

    var resource = $resource('api', {}, {

        sentence_items: { method: 'POST', url: window.apihost + 'api/sentence/items' },
        sentence_item: { method: 'POST', url: window.apihost + 'api/sentence/item' },
        sentence_basic: { method: 'POST', url: window.apihost + 'api/sentence/basic' },
        sentence_count: { method: 'POST', url: window.apihost + 'api/sentence/count' },
        sentence_update: { method: 'POST', url: window.apihost + 'api/sentence/update' },
        sentence_create: { method: 'POST', url: window.apihost + 'api/sentence/create' },
        sentence_empty: { method: 'POST', url: window.apihost + 'api/sentence/empty' },
        sentence_enable: { method: 'POST', url: window.apihost + 'api/sentence/enable' },
        sentence_disable: { method: 'POST', url: window.apihost + 'api/sentence/disable' },

        user_profile: { method: 'POST', url: window.apihost + 'api/user/profile' }
    });

    return {

        sentence_items: function (request) { var d = $q.defer(); resource.sentence_items({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_item: function (request) { var d = $q.defer(); resource.sentence_item({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_basic: function (request) { var d = $q.defer(); resource.sentence_basic({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_update: function (request) { var d = $q.defer(); resource.sentence_update({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_count: function (request) { var d = $q.defer(); resource.sentence_count({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_create: function (request) { var d = $q.defer(); resource.sentence_create({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_empty: function (request) { var d = $q.defer(); resource.sentence_empty({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_enable: function (request) { var d = $q.defer(); resource.sentence_enable({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },
        sentence_disable: function (request) { var d = $q.defer(); resource.sentence_disable({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; },

        user_profile: function (request) { var d = $q.defer(); resource.user_profile({}, request, function (result) { d.resolve(result); }, function (result) { process(result, d); }); return d.promise; }
    }
}
