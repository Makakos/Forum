

$(function () {

    $('.editMessageLink').click(function (event) {

        var PlaceHolderElement = $('#PlaceHolderHere');
        var mesId = event.target.id;
        var returnToUrl = PlaceHolderElement.find(".currentUrl").val();
        var messageText = $(`p[id="text ${mesId}"]`).text();

        var url = "/User/Messages/Edit";
        $.get(url).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find("#messageId").val(mesId);
            PlaceHolderElement.find("#redirectTo").val(returnToUrl);
            PlaceHolderElement.find("textarea").val(messageText);
            PlaceHolderElement.find('.modal').modal('show');
        })

     
    })

    $('.deleteMessageButton').click(function (event) {

        var url = "/User/Messages/Delete";
        var discussionId = $('input[id="discussionId"]').val();
        var redirectUrl = `/Discussions/Discussion/${discussionId}`;
        var mesId = event.target.id;
        $(`div[id="message ${mesId}"`).hide();
        $.post(url, { Id: mesId, RedirectUrl: redirectUrl }).done(function () { alert("Message deleted"); })


    })

    $('#addMessage').click(function (event) {

        var url = "/User/Messages/Create";
        var message = $('textarea[id="commentText"]').val();
        var discussionId = $('input[id="discussionId"]').val();
        var redirectUrl = `/Discussions/Discussion/${discussionId}`;
       

        $.post(url, { TextMessage: message, RedirectUrl: redirectUrl }).done(function () { location.reload(); })


    })

    $('div[id="addTopic"]').on('click', '#newTopicSubmition', function (event)  {
      
        var url = "/User/Topics/Add";
        var name = $('input[id="newTopicArea"]').val();
        $.post(url, {topicName:name}).done(function (data) {
            location.reload();
        })
    })
})




