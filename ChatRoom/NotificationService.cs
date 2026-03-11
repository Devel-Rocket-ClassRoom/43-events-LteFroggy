using System;

class NotificationService {
    public void EmergencyAlert(string sender, string message) {
        if (message.IndexOf("긴급") != -1) {
            Console.WriteLine($"[알림] 긴급 메세지 수신!");
        }
    }
}