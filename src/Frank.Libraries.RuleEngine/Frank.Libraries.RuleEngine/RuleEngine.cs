namespace Frank.Libraries.RuleEngine;

public class RuleEngine<T, R> : IRuleEngine<T, R>
{
    private readonly IRuleSet<T, R> _ruleSet;

    public RuleEngine(IRuleSet<T, R> ruleSet) => _ruleSet = ruleSet ?? throw new ArgumentNullException(nameof(ruleSet));

    public R Run(T facts)
    {
        var result = default(R);

        foreach (var rule in _ruleSet)
        {
            if (rule.Evaluate(facts))
            {
                result = rule.Execute(facts);
            }
        }

        return result;
    }
}