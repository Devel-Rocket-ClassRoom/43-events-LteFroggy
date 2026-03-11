using System;

class GameEventArgs : EventArgs {
    public string EventName;
    public object Data;

    public GameEventArgs(string eventName, object data) {
        EventName = eventName;
        Data = data;
    }
}