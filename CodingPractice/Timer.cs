using System;

class Timer {
    private int _count = 0;
    public event Action Tick;

    public void OnTick() {
        _count++;
        Console.WriteLine($"타이머 : {_count}초");
        Tick?.Invoke();
    }
}