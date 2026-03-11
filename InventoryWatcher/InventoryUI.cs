using System;

class InventoryUI {

    public void PrintUI(string itemName, int oldCount, int newCount) {
        Console.WriteLine($"[UI] {itemName} : {oldCount} -> {newCount}");
    }
}