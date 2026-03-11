using System;

class FuelEventArgs : EventArgs {
    public int Fuel;
    public string Message;

    public FuelEventArgs(int fuel, string message) {
        Fuel = fuel;
        Message = message;
    }
}