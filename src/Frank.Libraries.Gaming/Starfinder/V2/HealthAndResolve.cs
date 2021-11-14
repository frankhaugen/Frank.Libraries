namespace Frank.Libraries.Gaming.Starfinder.V2;

public class HealthAndResolve
{
    private readonly int _maxHealth;
    private int _health = 0;

    private readonly int _maxStamina;
    private int _stamina = 0;

    private readonly int _maxResolve;
    private int _resolve = 0;

    public HealthAndResolve(int maxHealth, int maxStamina, int maxResolve)
    {
        _maxHealth = maxHealth;
        _maxStamina = maxStamina;
        _maxResolve = maxResolve;
    }

    public int GetHealth() => _health;
    public int GetMaxHealth() => _maxHealth;
    public void AddHealth(int value) => _health += value;
    public void ReduceHealth(int value) => _health -= value;

    public int GetStamina() => _stamina;
    public int GetMaxStamina() => _maxStamina;
    public void AddStamina(int value) => _stamina += value;
    public void ReduceStamina(int value) => _stamina -= value;

    public int GetResolve() => _resolve;
    public int GetMaxResolve() => _maxResolve;
    public void AddResolve(int value) => _resolve += value;
    public void ReduceResolve(int value) => _resolve -= value;
}