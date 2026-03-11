using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
void HandleClick() {
    Console.WriteLine($"버튼이 클릭되었습니다!");
}
void HandleClickAgain() {
    Console.WriteLine($"클릭 처리 완료");
}

// 1. 대리자 복습
{
    Notify SayHello = () => Console.WriteLine($"안녕하세요!");
    Notify SayGoodbye = () => Console.WriteLine($"안녕히 가세요!");
    SayHello();
    SayGoodbye();
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 기본 이벤트 선언
{
    Button btn = new Button();
    
    btn.Click += HandleClick;
    btn.Click += HandleClickAgain;

    btn.OnClick();
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 이벤트 구독
{
    Player p = new Player();
    HealthBar hpBar = new HealthBar();
    SoundManager sm = new SoundManager();

    p.DamageTaken += hpBar.UpdateHealthBar;
    p.DamageTaken += sm.PlayHitSound;
    
    p.GetDamage(30);
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 이벤트 해제
{
    Logger logger = new Logger();
    Timer timer = new Timer();

    Console.WriteLine($"=== 구독 상태 ===");
    timer.Tick += logger.AddLog;
    timer.OnTick();
    timer.OnTick();
    timer.OnTick();
    Console.WriteLine();

    Console.WriteLine($"=== 구독 해제 후 ===");
    timer.Tick -= logger.AddLog;
    timer.OnTick();
    timer.OnTick();
    timer.OnTick();
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 람다식 이벤트 핸들러
{
    Sensor sensor = new Sensor();
    sensor.Alert += (str) => Console.WriteLine($"[경보] {str}");
    sensor.Alert += (str) => Console.WriteLine($"[로그] {DateTime.Now} : {str}");

    sensor.OnAlert("움직임 감지됨");
    Console.WriteLine();
    sensor.OnAlert("온도 상승");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. Action 대리자 활용
{
    GameCharacter character = new GameCharacter(100);

    character.OnDeath += () => Console.WriteLine($"캐릭터가 사망했습니다.");
    character.OnDamage += (amount) => Console.WriteLine($"남은 체력 : {amount}");
    character.OnAttack += (damage, target) => Console.WriteLine($"{target}에게 {damage} 데미지!");

    character.Attack(50, "슬라임");
    character.GetDamage(30);
    character.GetDamage(80);
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 표준 이벤트 패턴 (EventArgs) 
{
    Stock stock = new Stock("MSFT", 100);

    stock.OnPriceChanged += (obj, handler) => {
        Stock stock = (Stock)obj;
        Console.WriteLine($"[{stock.Unit}] : \\{handler.NewPrice}");
        Console.WriteLine($"  이전 가격 : \\{handler.OldPrice}");
        Console.WriteLine($"  현재 가격 : \\{handler.NewPrice}");
        Console.WriteLine($"  변동률 : {handler.ChangePercent:F2}%");
        Console.WriteLine();
    };

    stock.ChangePrice(110);
    stock.ChangePrice(106);
    stock.ChangePrice(120);
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 실전 예제 - 연료 경고 시스템
{
    Car car = new Car(50);
    Dashboard dashboard = new Dashboard();

    car.OnFuelChanged += dashboard.PrintGage;

    car.Drive();
    Console.WriteLine();
    car.Drive();
    Console.WriteLine();
    car.Drive();
    Console.WriteLine();
    car.Drive();
    Console.WriteLine();
    car.Drive();
    Console.WriteLine();
    Console.WriteLine();
}

void Handler1(object sender, EventArgs e) {
    Console.WriteLine($"handler1 실행됨");
}

void Handler2(object sender, EventArgs e) {
    Console.WriteLine($"handler2 실행됨");
}

// 9. 이벤트 접근자
{
    SecurePublisher securePublisher = new SecurePublisher();
    securePublisher.Event += Handler1;
    securePublisher.Event += Handler2;

    securePublisher.PublishEvent();

    securePublisher.Event -= Handler1;
    securePublisher.Event -= Handler2;
    Console.WriteLine();
    Console.WriteLine();
}

// 10. static 이벤트
{
    Module m1 = new Module("Module1");
    Module m2 = new Module("Module2");

    GlobalNotifier.SendMessage("시스템 시작");
    Console.WriteLine();
    GlobalNotifier.SendMessage("데이터 로드 완료");
    Console.WriteLine();
    Console.WriteLine();
}

delegate void EventHandler2();
delegate void Notify();