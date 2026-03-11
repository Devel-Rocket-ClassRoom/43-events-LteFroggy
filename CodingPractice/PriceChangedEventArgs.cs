using System;

class PriceChangedEventArgs : EventArgs {
    public int OldPrice;
    public int NewPrice;
    public double ChangePercent;

    public PriceChangedEventArgs(int oldPrice, int newPrice) {
        OldPrice = oldPrice;
        NewPrice = newPrice;
        ChangePercent = (oldPrice - newPrice) / (double)oldPrice * 100;
    }
}