using System.Collections.Generic;
using Frank.Libraries.Security.PasswordGeneration;
using Frank.Libraries.Security.Shared;

namespace Frank.Libraries.Security;

public class PasswordGenerator
{
    /// <summary>
    ///     The default password length that is reasonably easy to remember
    /// </summary>
    public const int DefaultPasswordLength = 12;

    private readonly Dictionary<CharacterVariant, string> _characters;
    private readonly PasswordGeneratorHelper _generatorHelper;

    public PasswordGenerator()
    {
        _characters = new Dictionary<CharacterVariant, string>();
        _generatorHelper = new PasswordGeneratorHelper(_characters);
    }

    /// <summary>
    ///     Generate a password string
    /// </summary>
    /// <param name="characterVariants">The variants of characters to use</param>
    /// <returns>The password string</returns>
    public string GeneratePassword(params CharacterVariant[] characterVariants)
    {
        _generatorHelper.EnsurePositiveCharacterCount(DefaultPasswordLength);
        _generatorHelper.EnsurePositiveCharacterVariantCount(characterVariants);
        _generatorHelper.AddCharacterVariantsToDictionary(characterVariants);

        var password = _generatorHelper.CreatePasswordString(DefaultPasswordLength);
        ClearCharacters();
        return password;
    }

    /// <summary>
    ///     Generate a password string
    /// </summary>
    /// <param name="characterVariants">The variants of characters to use</param>
    /// <returns>The password string</returns>
    public string GeneratePassword(int passwordLength = DefaultPasswordLength, params CharacterVariant[] characterVariants)
    {
        _generatorHelper.EnsurePositiveCharacterCount(passwordLength);
        _generatorHelper.EnsurePositiveCharacterVariantCount(characterVariants);
        _generatorHelper.AddCharacterVariantsToDictionary(characterVariants);

        var password = _generatorHelper.CreatePasswordString(passwordLength);
        ClearCharacters();
        return password;
    }

    /// <summary>
    ///     Generate a password string based on three default character types
    /// </summary>
    /// <param name="characterCount">A positive integer of how many characters the password should be</param>
    /// <returns>The password string</returns>
    public string GeneratePassword(int characterCount = DefaultPasswordLength)
    {
        _generatorHelper.EnsurePositiveCharacterCount(characterCount);
        _characters.Add(CharacterVariant.Digits, CharacterLists.Digits);
        _characters.Add(CharacterVariant.Lowercase, CharacterLists.Lowercase);
        _characters.Add(CharacterVariant.Uppercase, CharacterLists.Uppercase);

        var password = _generatorHelper.CreatePasswordString(characterCount);
        ClearCharacters();
        return password;
    }

    private void ClearCharacters() => _characters.Clear();
}