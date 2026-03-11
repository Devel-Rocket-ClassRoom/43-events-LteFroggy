using System;

class Dashboard {
    public void PrintGage(int fuel) {
        Console.WriteLine($"[대시보드] 연료 게이지 : {new string('█', fuel / 10)}");
    }
}