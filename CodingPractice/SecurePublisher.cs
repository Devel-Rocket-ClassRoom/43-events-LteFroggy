using System;

class SecurePublisher {
    private event System.EventHandler _event;
    private object _lock = new object();

    public event EventHandler Event {
        add {
            lock(_lock) {
                _event += value;
                Console.WriteLine($"구독자 추가 : {value.Method.Name}");
            }
        } remove {
            lock(_lock) {
                _event -= value;
                Console.WriteLine($"구독자 제거 : {value.Method.Name}");
            }
        }
    }

    public void PublishEvent() {
        _event?.Invoke(this, EventArgs.Empty);
    }
}