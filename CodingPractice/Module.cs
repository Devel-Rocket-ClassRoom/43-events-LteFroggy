using System;

class Module {
    private string _name;
    public Module(string name) {
        _name = name;
        GlobalNotifier.OnGlobalMessage += Receive;
    }
    ~Module() {
        GlobalNotifier.OnGlobalMessage -= Receive;
    }

    public void Receive(string str) {
        Console.WriteLine($"[{_name}] 수신 : {str}");
    }
}