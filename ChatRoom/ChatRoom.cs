using System;

class ChatRoom {
    public event Action<string, string> OnMessageReceived;

    public void SendMessage(string sender, string message) {
        OnMessageReceived?.Invoke(sender, message);
    }
}