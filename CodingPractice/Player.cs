using System;

class Player {
    private int _health;
    public event Action<int> DamageTaken;

    public Player(int health = 100) {
        _health = health;
    }

    public void GetDamage(int amount) {
        _health += amount;
        DamageTaken?.Invoke(_health);
    }
}