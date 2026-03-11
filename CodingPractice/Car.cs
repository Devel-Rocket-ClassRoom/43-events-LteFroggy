using System;

class Car {
    private int _fuel;
    public event EventHandler<FuelEventArgs> OnFuelLow;
    public event Action<int> OnFuelChanged;

    public Car(int fuel) {
        _fuel = fuel;
        OnFuelChanged += (fuel) => {
            if (fuel <= 20) {
                OnFuelLow?.Invoke(this, new FuelEventArgs(fuel, "연료가 부족합니다."));
            }
        };

        OnFuelLow += (obj, fuel) => {
            Console.WriteLine($"[경고!] 연료가 부족합니다. (잔량 : {fuel.Fuel}%)");
        };
    }

    public int Fuel {
        get => _fuel;
    }

    public void Drive() {
        if (_fuel < 10) {
            Console.WriteLine($"연료 없음! 운전 불가");
            return;
        }
        _fuel -= 10;
        Console.WriteLine($"운전 중... 연료 : {_fuel}%");
        OnFuelChanged(_fuel);
    }

    public void ChargeFuel(int amount) {
        _fuel += amount;
        OnFuelChanged?.Invoke(_fuel);
    }

}