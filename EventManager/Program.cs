using System;

SoundSystem sound = new SoundSystem();
ScoreSystem sc = new ScoreSystem();
AchievementSystem achievement = new AchievementSystem();


EventManager.TriggerEvent("ScoreChanged", 100);
EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
EventManager.TriggerEvent("GameOver");
Console.WriteLine();
Console.WriteLine();
