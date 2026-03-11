using System;

class AchievementSystem {
    public AchievementSystem() {
        EventManager.OnGameEvent += Acievement;
    }

    ~AchievementSystem() {
        EventManager.OnGameEvent -= Acievement;
    }

    public void Acievement(object sender, GameEventArgs e) {
        if (e.EventName == "Achievement") {
            Console.WriteLine($"업적 달성 : {e.Data}");
        }
    }
}