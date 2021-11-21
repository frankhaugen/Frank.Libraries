using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using FluentValidation;

namespace Frank.Libraries.FluentValidation
{
    public static class ThrowRule
    {
        private static string _errorMessage = "No error";

        public static void ThrowsNot<T>(this IRuleBuilder<T, Action> ruleBuilder)
        {
            ruleBuilder
                .Must(TryExecute)
                .WithMessage(x => _errorMessage)
                .WithSeverity(Severity.Error);
        }

        private static void CreateErrorMessage<TException>(TException exception) where TException : Exception
        {
            var messageBuilder = new StringBuilder();
            messageBuilder.AppendLine($"=============== ERROR ===============");
            messageBuilder.AppendLine($"{exception.ToTitleCase()}");
            messageBuilder.AppendLine($"\tSource: {exception.Source}");
            messageBuilder.AppendLine($"\tMessage: {exception.Message}");
            messageBuilder.AppendLine($"\tStackTrace:");
            foreach (var line in exception.StackTrace?.Replace("\r", "")
                                          .Split("\n")!)
            {
                messageBuilder.AppendLine($"\t\t{line}");
            }

            if (exception.InnerException != null)
            {
                messageBuilder.AppendLine($"\tInner Exception:");
                messageBuilder.AppendLine($"\t\tInner Exception: {exception.InnerException}");
            }

            _errorMessage = messageBuilder.ToString();
        }

        private static bool TryExecute(Action action)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch (Exception e)
            {
                CreateErrorMessage(e);
                return false;
            }
        }

        private static string ToSentenceCase<T>(this T source) where T : Exception => Regex.Replace(source.GetType()
                                                                                                          .Name, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");

        private static string ToTitleCase<T>(this T source) where T : Exception
        {
            var sentenceCase = source.ToSentenceCase();
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(sentenceCase);
        }
    }
}