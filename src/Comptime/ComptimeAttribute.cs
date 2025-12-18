namespace Comptime;

/// <summary>
/// Marks a method for compile-time execution and result serialization.
/// The annotated method must be static, parameterless, and return a serializable type.
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Method)]
public sealed class ComptimeAttribute : System.Attribute
{
    /// <summary>
    /// Marks the method for compile-time execution.
    /// </summary>
    public ComptimeAttribute() { }
}
