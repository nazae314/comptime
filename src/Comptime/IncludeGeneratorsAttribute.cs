namespace Comptime;

/// <summary>
/// Specifies source generator assemblies that should be executed on the compilation before
/// emitting the assembly for method execution.
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Method | System.AttributeTargets.Class, AllowMultiple = false)]
public sealed class IncludeGeneratorsAttribute : System.Attribute
{
    /// <summary>
    /// Gets the assembly names of the source generators to run.
    /// </summary>
    public string[] GeneratorAssemblies { get; }

    /// <summary>
    /// Specifies source generator assemblies to run before emitting the compilation.
    /// </summary>
    public IncludeGeneratorsAttribute(params string[] generatorAssemblies)
    {
        GeneratorAssemblies = generatorAssemblies ?? System.Array.Empty<string>();
    }
}
