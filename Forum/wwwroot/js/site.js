

$(function () {

    
    $('a[data-toggle="ajax-model"]').click(function (event) {

        var PlaceHolderElement = $('#PlaceHolderHere');
        var mesId = $('a[data-toggle="ajax-model"]').attr("id");
        var returnToUrl = PlaceHolderElement.find(".currentUrl").val();
        var messageText = $(`p[id="text ${mesId}"]`).text();

        var url = $(this).data('url');
        $.get(url).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find("#messageId").val(mesId);
            PlaceHolderElement.find("#redirectTo").val(returnToUrl);
            PlaceHolderElement.find("textarea").val(messageText);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })

   
    
})




