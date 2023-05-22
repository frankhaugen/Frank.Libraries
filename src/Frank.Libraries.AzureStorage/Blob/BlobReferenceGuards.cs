using System;
using System.Text.RegularExpressions;

namespace Frank.Libraries.AzureStorage.Blob;

public static class BlobReferenceGuards
{
    public static void GuardContainerName(string containerName)
    {
        if (string.IsNullOrWhiteSpace(containerName))
        {
            throw new ArgumentException("Container name cannot be null or empty.");
        }

        if (containerName.Length < 3 || containerName.Length > 63)
        {
            throw new ArgumentException("Container name must be from 3 through 63 characters long.");
        }

        if (!Regex.IsMatch(containerName, "^[a-z0-9]([-a-z0-9]*[a-z0-9])?$"))
        {
            throw new ArgumentException("Container name must start or end with a letter or number, and can contain only letters, numbers, and the dash (-) character. Every dash (-) character must be immediately preceded and followed by a letter or number; consecutive dashes are not permitted in container names. All letters in a container name must be lowercase.");
        }
    }


    public static void GuardBlobName(string blobName, bool hasHierarchicalNamespace = false)
    {
        if (string.IsNullOrEmpty(blobName))
        {
            throw new ArgumentException("Blob name cannot be null or empty.");
        }

        if (blobName.Length
            > (hasHierarchicalNamespace
                ? 1024
                : 256))
        {
            throw new ArgumentException("Blob name cannot be more than "
                                        + (hasHierarchicalNamespace
                                            ? "1,024"
                                            : "256")
                                        + " characters long.");
        }

        if (!hasHierarchicalNamespace
            && blobName.Split('/')
                       .Length
            > 254)
        {
            throw new ArgumentException("Blob name cannot have more than 254 path segments.");
        }

        if (blobName.EndsWith(".") || blobName.EndsWith("/"))
        {
            throw new ArgumentException("Blob name cannot end with a dot (.) or a forward slash (/).");
        }

        // Check for reserved URL characters
        var reservedChars = new[] { '<', '>', ':', '"', '/', '\\', '|', '?', '*', '&', '\'' };
        if (blobName.IndexOfAny(reservedChars) != -1)
        {
            throw new ArgumentException("Blob name contains reserved URL characters that must be properly escaped.");
        }
    }
}