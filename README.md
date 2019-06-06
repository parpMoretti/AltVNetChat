# AltVNetChat

This is my first public resource in a long time so please bare with.

## Setup

Under your OnStart module in C# you need to use the following to start a command handler.

```Alt.OnClient("chatmessage", ChatExtension.OnChatMessage);```

This pushes the message the player types to the ChatExtension.cs file.

## Sending messages to the player

If you wish to send a message to the players chat box, you can use the following.

You can set the `SENDER` field to `null` or as a string for a sender. Message is also a string.

```player.Emit("chatmessage", "SENDER", "MESSAGE");```

## Chat Colors

To set a message's color (Unable to for sender yet), you need to use the following:

```player.Emit("chatmessage", "[INFO]", "{FDFE8B}" + message);```

This would send a white [INFO] with yellow message string

## Toggle Chat Input

To stop input onto the chat you can send the following event to the player.

```
alt.onServer('toggleChat', (state) => {
	hidden = state;
});```
