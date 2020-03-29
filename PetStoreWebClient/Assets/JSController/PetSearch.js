var common = {
    init: function () {
        common.registerEvent();
    },
    registerEvent: function () {
        $("#txtKeywordPet").autocomplete({
            minLength: 0,
            source: function( request, response ) {
                $.ajax( {
                    url: "/Pet/ListName",
                    dataType: "json",
                    data: {
                        p: request.term
                    },
                    success: function( res ) {
                        response( res.data );
                    }
                });
            },
            focus: function (event, ui) {
                $("#txtKeywordPet").val(ui.item.label);
                return false;
            },
            select: function (event, ui) {
                $("#txtKeywordPet").val(ui.item.label);
                return false;
            }
        })
        .autocomplete("instance")._renderItem = function (ul, item) {
            return $("<li id='autocompleteItem'>")
           .append("<div>" + item.label + "</div>")
           .appendTo(ul);
        };
    }
}
common.init();