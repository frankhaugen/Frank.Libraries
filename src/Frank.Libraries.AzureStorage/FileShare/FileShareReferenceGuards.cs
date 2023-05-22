namespace Frank.Libraries.AzureStorage.FileShare;

internal static class FileShareReferenceGuards
{
    private static readonly char[] InvalidChars = { '\"', '\\', '/', '[', ']', ':', '|', '<', '>', '+', '=', ';', ',', '*', '?' };
    private static readonly char[] ControlChars = Enumerable.Range(0, 32).Select(i => (char)i).ToArray();

    public static void EnsureValid(string shareName)
    {
        if (string.IsNullOrEmpty(shareName))
        {
            throw new ArgumentNullException(nameof(shareName), "Share name cannot be null or empty.");
        }

        if (shareName.Length > 80)
        {
            throw new ArgumentException("Share name cannot be longer than 80 characters.", nameof(shareName));
        }

        if (shareName.Any(c => InvalidChars.Contains(c) || ControlChars.Contains(c)))
        {
            throw new ArgumentException("Share name contains invalid characters.", nameof(shareName));
        }
    }


    public static void ValidateDirectoryName(string directoryName)
    {
        if (string.IsNullOrWhiteSpace(directoryName))
        {
            throw new ArgumentException("Directory name cannot be null or empty.");
        }

        if (directoryName.Length > 255)
        {
            throw new ArgumentException("Directory name cannot be longer than 255 characters.");
        }

        if (directoryName.EndsWith("/"))
        {
            throw new ArgumentException("Directory name cannot end with the forward slash character (/).");
        }

        if (!IsValidUrlPath(directoryName))
        {
            throw new ArgumentException("Directory name contains invalid characters.");
        }

        if (IsReservedDirectoryName(directoryName))
        {
            throw new ArgumentException("Directory name is reserved and cannot be used.");
        }
    }

    public static void ValidateFileName(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            throw new ArgumentException("File name cannot be null or empty.");
        }

        if (fileName.Length > 255)
        {
            throw new ArgumentException("File name cannot be longer than 255 characters.");
        }

        if (fileName.EndsWith("/"))
        {
            throw new ArgumentException("File name cannot end with the forward slash character (/).");
        }

        if (!IsValidUrlPath(fileName))
        {
            throw new ArgumentException("File name contains invalid characters.");
        }

        if (IsReservedFileName(fileName))
        {
            throw new ArgumentException("File name is reserved and cannot be used.");
        }
    }

    private static bool IsValidUrlPath(string path)
    {
        // Implement validation logic for reserved URL characters and illegal URL path characters
        // See https://docs.microsoft.com/en-us/rest/api/storageservices/naming-and-referencing-shares--directories--files--and-metadata#naming-and-referencing-objects-in-a-share
        return true;
    }

    private static bool IsReservedDirectoryName(string directoryName)
    {
        // Implement validation logic for reserved directory names
        // See https://docs.microsoft.com/en-us/rest/api/storageservices/naming-and-referencing-shares--directories--files--and-metadata#directory-names
        return false;
    }

    private static bool IsReservedFileName(string fileName)
    {
        // Implement validation logic for reserved file names
        // See https://docs.microsoft.com/en-us/rest/api/storageservices/naming-and-referencing-shares--directories--files--and-metadata#file-names
        return false;
    }
}