namespace Frank.Libraries.RuleEngine;

public interface IRuleSet<T, R> : IEnumerable<IRule<T, R>>
{
    void AddRule(IRule<T, R> rule);
    void RemoveRule(IRule<T, R> rule);
}