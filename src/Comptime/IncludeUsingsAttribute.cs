namespace Comptime;

/// <summary>
/// Specifies additional using directives to include in the generated source code.
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Method | System.AttributeTargets.Class, AllowMultiple = false)]
public sealed class IncludeUsingsAttribute : System.Attribute
{
    /// <summary>
    /// Gets the namespaces to include as using directives in the generated code.
    /// </summary>
    public string[] Usings { get; }

    /// <summary>
    /// Specifies additional using directives to include in the generated code.
    /// </summary>
    public IncludeUsingsAttribute(params string[] usings)
    {
        Usings = usings ?? System.Array.Empty<string>();
    }
}
