namespace Frank.Libraries.RuleEngine;

public interface IRule<T, R>
{
    Func<T, R> Execute { get; }
    bool Evaluate(T facts);
}