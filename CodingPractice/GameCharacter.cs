using System;
using System.Runtime.InteropServices;

class GameCharacter {
    private int _health;

    public GameCharacter(int health) {
        _health = health;
    }

    public event Action OnDeath;
    public event Action<int> OnDamage;
    public event Action<int, string> OnAttack;

    private void Death() {
        OnDeath?.Invoke();
    }

    public void GetDamage(int damage) {
        _health = Math.Clamp(_health - damage, 0, 100);
        OnDamage?.Invoke(_health);
        
        if (_health <= 0) Death();
    }

    public void Attack(int amount, string target) {
        OnAttack?.Invoke(amount, target);
    }
}