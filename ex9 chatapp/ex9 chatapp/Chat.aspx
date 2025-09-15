<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="ex9_chatapp.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Chat</title>
    <style>
        #messages { border:1px solid #ccc; height:300px; width:400px; overflow:auto; padding:10px; }
        #username, #message { width:200px; margin:5px; }
    </style>
</head>
<body>
    <form runat="server">
        <h2>Simple Chat</h2>
        <div id="messages"></div><br />
        Username: <input type="text" id="username" /><br />
        Message: <input type="text" id="message" /><br />
        <button type="button" id="sendBtn">Send</button>
    </form>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="Scripts/jquery.signalR-2.4.3.js"></script>  <!-- ADD THIS -->
    <script src="/signalr/hubs"></script>
    <script>
        var chat = $.connection.chatHub;

        chat.client.receiveMessage = function (msg) {
            $('#messages').append('<div>' + $('<div>').text(msg).html() + '</div>');
            $('#messages').scrollTop($('#messages')[0].scrollHeight);
        };

        $.connection.hub.start().done(function () {
            // load previous messages
            chat.server.getAllMessages().done(function (msgs) {
                msgs.forEach(function (m) {
                    $('#messages').append('<div>' + $('<div>').text(m).html() + '</div>');
                });
            });

            $('#sendBtn').click(function () {
                var user = $('#username').val();
                var msg = $('#message').val();
                if (!user || !msg) { alert("Enter username and message"); return; }
                chat.server.sendMessage(user, msg);
                $('#message').val('');
            });
        });
    </script>
</body>
</html>
