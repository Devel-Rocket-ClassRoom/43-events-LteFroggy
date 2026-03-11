using System;

ChatRoom room = new ChatRoom();
ChatLogger logger = new ChatLogger();
NotificationService notificationService = new NotificationService();

room.OnMessageReceived += logger.LogChat;
room.OnMessageReceived += notificationService.EmergencyAlert;

room.SendMessage("철수", "안녕하세요");
room.SendMessage("영희", "긴급 회의가 있습니다");
room.SendMessage("철수", "점심 뭐 먹을까요?");
Console.WriteLine();
Console.WriteLine();
