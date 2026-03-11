using System;

class Stock {
    private string _unit;
    private int _price;

    public EventHandler<PriceChangedEventArgs> OnPriceChanged;

    public string Unit {
        get => _unit;
    }
    public int Price {
        get => _price;
    }

    public Stock(string unit, int price) {
        _unit = unit;
        _price = price;
    }

    public void ChangePrice(int newPrice) {
        OnPriceChanged?.Invoke(this, new PriceChangedEventArgs(_price, newPrice));
        _price = newPrice;
    }
}