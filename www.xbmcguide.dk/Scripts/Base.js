
$(document).ready(function () {
    $(function () {
        $('#Search').autocomplete({
            source: function (request, response) {
                jQuery.ajax({
                    url: "/AutoComplete/SearchResult",
                    type: "post",
                    dataType: "json",
                    data: { q: request.term },
                    success: function (data) {
                        response(jQuery.map(data, function (item) {
                            return {
                                url: "/artikel/" + item.Id,
                                value: item.Heading
                            };
                        }));
                    }
                });
            },
            select: function (event, ui) {
                window.location.href = ui.item.url;
            },
            minLength: 2
        });
    });
});

//$(document).ready(function () {
//    $.ajax({
//        url: '/AutoComplete/SearchResult',
//        type: "POST",
//        dataType: "json",
//        data: { q: "XBMC" },
//        contentType: "application/json; charset=utf-8",
//        success: function (data) {
//            response($.map(data, function (item) {
//                return { label: item, value: item };
//            }));
//        }
//    });
//});