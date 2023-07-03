using System.Collections;

namespace Frank.Libraries.RuleEngine;

public abstract class BaseRuleSet<T, R> : IRuleSet<T, R>
{
    private readonly List<IRule<T, R>> rules = new();

    public IEnumerator<IRule<T, R>> GetEnumerator() => rules.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void AddRule(IRule<T, R> rule) => rules.Add(rule);

    public void RemoveRule(IRule<T, R> rule) => rules.Remove(rule);
}