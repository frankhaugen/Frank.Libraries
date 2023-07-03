namespace Frank.Libraries.RuleEngine;

public interface IRuleEngine<T, R>
{
    R Run(T facts);
}