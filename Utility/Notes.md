
# `Program.Extensions.cs

### `partial class Program`
```csharp
using Utility;

/*
- [Add a Property to the Top-level Statements Program class](https://khalidabuhakmeh.com/add-a-property-to-the-top-level-statements-program-class) 
- Uses `partial class`

Instead of using a method like ...
Console.WriteLine($"Hello, {GetName()}");  
public static string  GetName() { return Environment.GetCommandLineArgs()[1]; }

You can use a property (which is more readable than a method) like shown below in the `partial class`

For this to work, you need to change `Program.cs`
- Change `internal class Program` to `internal partial class Program`

 */

partial class Program
{
	static string Name => Environment.GetCommandLineArgs()[1];
	static string? ProcessPath => Environment.ProcessPath;
	static string? CurrentDirectory => Environment.CurrentDirectory;
	static string? UserName => Environment.UserName;
}
```


# Inside `internal partial class Program`
```

		//---

		//Console.WriteLine();

		Console.WriteLine($"Hello, {Name}");
		Console.WriteLine($"ProcessPath, {ProcessPath}");
		Console.WriteLine($"CurrentDirectory, {CurrentDirectory}");
		Console.WriteLine($"UserName, {UserName}");

```