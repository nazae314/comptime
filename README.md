# Comptime

A .NET source generator that executes methods at compile time and serializes their results to C# code. Comptime brings meta-programming capabilities to C#, enabling compile-time code generation and evaluation.

## Overview

Comptime allows you to mark methods with the `[Comptime]` attribute to have them executed during compilation. The return values are serialized into C# source code and used at runtime, eliminating the need for runtime computation of values that can be determined at build time.

This meta-programming approach enables developers to shift expensive computations from runtime to compile time, resulting in faster application startup and execution.

## Features

- **Compile-time execution**: Methods marked with `[Comptime]` are executed during compilation
- **C# serialization**: Results are serialized to valid C# code
- **Supported types**: 
  - Primitive types: `int`, `long`, `short`, `byte`, `sbyte`, `uint`, `ulong`, `ushort`, `float`, `double`, `decimal`, `bool`, `char`, `string`
  - Collections: `IList<T>`, `IReadOnlyList<T>`, `IReadOnlyDictionary<TKey, TValue>`
- **Interceptor-based**: Uses C# interceptors to replace method calls with pre-computed values

## Usage

```csharp
using Comptime;

public static partial class Constants
{
    [Comptime]
    public static int[] MagicNumbers()
    {
        // Complex computation that runs at compile time
        var numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            if (IsPrime(i))
                numbers.Add(i);
        }
        return numbers.ToArray();
    }
    
    private static bool IsPrime(int n) => /* ... */;
}

// At runtime, calling MagicNumbers() returns the pre-computed array
var primes = Constants.MagicNumbers(); // Returns [2, 3, 5, 7]
```

## Requirements

- .NET 8.0 or later
- C# 12 or later (for interceptors support)

## Installation

```xml
<PackageReference Include="Comptime" Version="1.0.0" />
```

## How It Works

1. The source generator finds methods marked with `[Comptime]`
2. It creates a temporary compilation and executes those methods
3. The return values are serialized to C# literals/expressions
4. Interceptor methods are generated that return the pre-computed values
5. At runtime, calls to the original methods are intercepted and return the cached values

## Limitations

- Methods must be `static` and parameterless
- Return types must be serializable (see supported types above)
- The containing class must be `partial`
- Methods cannot have side effects that depend on runtime state

## License

MIT License
