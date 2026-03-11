using System;
using System.Collections.Generic;

class Inventory {
    private Dictionary<string, int> _items;
    public event Action<string, int, int> OnItemChanged;

    public Inventory() {
        _items = new Dictionary<string, int>();
    }

    public void AddItem(string name, int count) {
        int oldCount = 0;
        if (_items.TryGetValue(name, out oldCount)) {
            _items[name] += count;
        } else {
            _items.Add(name, count);
        }
        
        OnItemChanged?.Invoke(name, oldCount, _items[name]);
    }

    public void RemoveItem(string name, int count) {
        int oldCount = _items[name];
        _items[name] = Math.Clamp(_items[name] - count , 0, Int32.MaxValue);

        OnItemChanged?.Invoke(name, oldCount, _items[name]);
    }
}
