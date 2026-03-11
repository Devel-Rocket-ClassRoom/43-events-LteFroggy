using System;

class ScoreSystem {
    public ScoreSystem() {
        EventManager.OnGameEvent += ScoreChanged;
    }
    ~ScoreSystem() {
        EventManager.OnGameEvent -= ScoreChanged;
    }

    public void ScoreChanged(object sender, GameEventArgs args) {
        if (args.EventName == "ScoreChanged")
        Console.WriteLine($"점수 변경 : {(int)args.Data}점");
    }
}