using System;
using System.IO;
using System.Xml.Schema;

namespace ublxsd;

public class UblXsdSettings
{
    public enum FieldTypesEnum
    {
        Field,
        Property,
        AutoProperty
    }

    private DirectoryInfo baseDir;

    /// <summary>
    ///     Parent of common and maindoc directories from the downloaded/unziped ubl package
    /// </summary>
    public string UblXsdInputPath
    {
        set
        {
            baseDir = new DirectoryInfo(value);
            try
            {
                CommonDirectory = baseDir.GetDirectories("common")[0];
                MaindocDirectory = baseDir.GetDirectories("maindoc")[0];
            }
            catch
            {
                throw new ArgumentException($"{nameof(UblXsdInputPath)} must point to xsd folder that have common and maindoc subfolders.", nameof(UblXsdInputPath));
            }

            if (CommonDirectory.GetFiles("*.xsd")
                               .Length
                == 0
                || MaindocDirectory.GetFiles("*.xsd")
                                   .Length
                == 0)
            {
                throw new ArgumentException($"{nameof(UblXsdInputPath)} Can't find *.xsd files in common and maindoc subfolders.", nameof(UblXsdInputPath));
            }
        }
    }

    public FieldTypesEnum OptionMemberTypeToGenerate { get; set; }

    public DirectoryInfo MaindocDirectory { get; private set; }

    public DirectoryInfo CommonDirectory { get; private set; }

    public ValidationEventHandler XsdValidationEvent { get; set; }

    /// <summary>
    ///     Generated codefiles are written to this path
    /// </summary>
    public string CodeGenOutputPath { get; set; }

    /// <summary>
    ///     Default code namespace used in generated code
    /// </summary>
    public string CSharpDefaultNamespace { get; set; }

    public bool OptionOptimizeCommonBasicComponents { get; internal set; }
}