using System;

static class EventManager {
    static public event EventHandler<GameEventArgs> OnGameEvent;

    static public void TriggerEvent(string eventName, object data = null) {
        OnGameEvent?.Invoke(null, new GameEventArgs(eventName, data));
    }
}