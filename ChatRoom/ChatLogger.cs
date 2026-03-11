using System;

class ChatLogger {
    public void LogChat(string sender, string message) {
        Console.WriteLine($"[로그] {sender} : {message}");
    }
}