namespace Frank.Libraries.IRC.Constants
{
    public static class ErrorMessages
    {
        public const string MessageInvalidUserRegistrationInfo = "The registration info for a user must have a valid nick name and user name.";
        public const string MessageInvalidChannelType = "The channel type '{0}' sent by the server is invalid.";
        public const string MessageTooManyParams = "No more than 15 command parameters may be specified.";
        public const string MessageInvalidQuotedChar = "The quoted character '{0}' was not recognised.";
        public const string MessageInvalidTag = "The message tag '{0}' is invalid.";
        public const string MessageInvalidMiddleParameter = "The non-trailing parameter '{0}' is invalid.";
        public const string MessageInvalidRegistrationInfoObject = "The object provided for registration info is of an unknown type.";
        public const string MessageInvalidRealName = "The specified real name is invalid.";
        public const string MessageInvalidUrlScheme = "The URL scheme '{0}' is not valid.";
        public const string MessageInvalidUserName = "The specified user name is invalid.";
        public const string MessageInvalidUserMode = "The specified user mode is invalid.";
        public const string MessageTargetMaskInvalidType = "The type of the given target mask '{0}' is invalid.";
        public const string MessageSourceNotUser = "The message source '{0}' is not a user.";
        public const string MessageInvalidServiceRegistrationInfo = "The registration info for a service must have a valid nick name and description.";
        public const string MessageCannotSetUserMode = "Cannot set user mode for '{0}'.";
        public const string MessageNoValidAddress = "The host name '{0}' does not resolve to a valid IP address.";
        public const string MessageIsupportPrefixInvalid = "The ISUPPORT message sent by the server contains an invalid PREFIX parameter.";
        public const string MessageTooManyModeParameters = "No more than 3 mode parameters may be sent per message.";
        public const string MessageInvalidTrailingParameter = "The trailing parameter '{0}' is invalid.";
        public const string MessageInvalidNickName = "The specified nick name is invalid.";
        public const string MessageInvalidSource = "The source '{0}' of the message was not recognised as either a server or user.";
        public const string MessageInvalidPrefix = "The message prefix '{0}' is invalid.";
        public const string MessageInvalidCommandDefinition = "The command definition '{0}' is invalid.";
        public const string MessageInvalidTargetName = "A target name may not contain any ',' character.";
        public const string MessageInvalidMessageCommand = "The command '{0}' was not recognised.";
        public const string MessageRawMessageTooLong = "The length of a raw message must not exceed {0} characters.";
        public const string MessageTargetMaskTooShort = "The target mask must be contain at least two characters.";
        public const string MessageInvalidCommand = "The message command '{0}' is invalid.";
        public const string MessageValueCannotBeEmptyString = "The value cannot be an empty string";
        public const string MessageNotEnoughModeParameters = "Not enough mode parameters were specified for the given modes.";
        public const string MessageInvalidPassword = "The specified password is invalid.";
    }
}