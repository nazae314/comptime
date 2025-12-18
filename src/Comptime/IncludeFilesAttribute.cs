namespace Comptime;

/// <summary>
/// Specifies additional source files to include in the compilation when executing
/// compile-time methods.
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Method | System.AttributeTargets.Class, AllowMultiple = false)]
public sealed class IncludeFilesAttribute : System.Attribute
{
    /// <summary>
    /// Gets the relative paths or glob patterns of the files to include.
    /// </summary>
    public string[] Files { get; }

    /// <summary>
    /// Specifies additional source files to include when executing the compile-time method.
    /// </summary>
    public IncludeFilesAttribute(params string[] files)
    {
        Files = files ?? System.Array.Empty<string>();
    }
}
