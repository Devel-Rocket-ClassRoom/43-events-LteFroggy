using System;

Inventory inventory = new Inventory();
InventoryUI ui = new InventoryUI();
AutoBuyer buyer = new AutoBuyer();

inventory.OnItemChanged += ui.PrintUI;
inventory.OnItemChanged += buyer.PrintBuyMessage;

inventory.AddItem("포션", 5);
inventory.AddItem("화살", 10);
inventory.AddItem("포션", 3);
inventory.RemoveItem("화살", 7);
inventory.RemoveItem("화살", 5);
Console.WriteLine();
Console.WriteLine();
