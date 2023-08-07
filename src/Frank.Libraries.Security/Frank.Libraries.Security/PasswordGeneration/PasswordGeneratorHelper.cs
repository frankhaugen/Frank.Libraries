using System.ComponentModel;
using System.Security.Cryptography;
using Frank.Libraries.Security.Shared;

namespace Frank.Libraries.Security.PasswordGeneration;

/// <summary>
///     This should be hidden
/// </summary>
[Browsable(false)]
[EditorBrowsable(EditorBrowsableState.Never)]
public class PasswordGeneratorHelper
{
    private readonly Dictionary<CharacterVariant, string> _characters;

    public PasswordGeneratorHelper(Dictionary<CharacterVariant, string> characters) => _characters = characters;

    public string CreatePasswordString(int characterCount)
    {
        var output = "";

        for (var i = 0; i < characterCount; i++)
        {
            var characters = CombineCharactersToSingleString();
            output += characters[GetRandom(CombineCharactersToSingleString()
                                               .Length
                                           - 1)];
        }

        return output;
    }

    public string CombineCharactersToSingleString() => string.Join("", _characters.SelectMany(x => x.Value)
                                                                                  .Select(x => x));

    public void AddCharacterVariantsToDictionary(CharacterVariant[] characterVariants)
    {
        EnsurePositiveCharacterVariantCount(characterVariants);

        foreach (var characterVariant in characterVariants)
        {
            switch (characterVariant)
            {
                case CharacterVariant.Digits:
                    _characters.Add(CharacterVariant.Digits, CharacterLists.Digits);
                    break;

                case CharacterVariant.Uppercase:
                    _characters.Add(CharacterVariant.Uppercase, CharacterLists.Uppercase);
                    break;

                case CharacterVariant.Lowercase:
                    _characters.Add(CharacterVariant.Lowercase, CharacterLists.Lowercase);
                    break;

                case CharacterVariant.Special:
                    _characters.Add(CharacterVariant.Special, CharacterLists.Special);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public void EnsurePositiveCharacterVariantCount(CharacterVariant[] characterVariants)
    {
        if (characterVariants.Length < 1)
        {
            throw new ArgumentException("Value cannot be less than 1", nameof(characterVariants));
        }
    }

    public void EnsurePositiveCharacterCount(int characterCount)
    {
        if (characterCount < 1)
        {
            throw new ArgumentException("Value cannot be less than 1", nameof(characterCount));
        }
    }

    public CharacterVariant GetRandomCharacterVariant() =>
        _characters.ElementAt(GetRandom(_characters.Count))
                   .Key;

    public int GetRandom(int maxValue)
    {
        var random = RandomNumberGenerator.GetInt32(maxValue);
        return random;
    }
}