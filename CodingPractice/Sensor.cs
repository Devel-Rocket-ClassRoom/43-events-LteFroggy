using System;

class Sensor {
    public event Action<string> Alert;

    public void OnAlert(string str) {
        Console.WriteLine($"감지 : {str}");
        Alert?.Invoke(str);
    }
}