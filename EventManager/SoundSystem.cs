using System;

class SoundSystem {
    public SoundSystem() {
        EventManager.OnGameEvent += PlaySound;
    }

    ~SoundSystem() {
        EventManager.OnGameEvent -= PlaySound;
    }

    public void PlaySound(object sender, GameEventArgs e) {
        Console.WriteLine($"[Sound] 이벤트 : {e.EventName}");
    }
}