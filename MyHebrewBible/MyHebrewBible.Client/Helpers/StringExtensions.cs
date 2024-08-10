using System.Text;

namespace MyHebrewBible.Client.Helpers;

public static class StringExtensions
{
	//ToDo: NOTE BEING USED
	public static StringBuilder AppendWhen(
		this StringBuilder sb, string value, bool predicate) => predicate ? sb.Append(value) : sb;


	//ToDo: NOTE BEING USED
	// See D:\TFS\OsisXmlToSql\BuildLetter\Helper\StringExtensions.cs
	public static StringBuilder AppendIf(this StringBuilder builder, bool condition, string value)
	{
		if (condition) builder.Append(value);
		return builder;
	}

	//ToDo: NOTE BEING USED
	public static string Truncate(this string value, int maxLength)
	{
		if (string.IsNullOrEmpty(value)) return value;
		return value.Length <= maxLength ? value : value.Substring(0, maxLength);
	}
	/*
	- C:\Users\JohnM\source\repos\LivingMessiahBlazor\LivingMessiah.Web\Infrastructure\StringExtensions.cs
	public static string Repeat
	public static string PhoneNumber
	*/
}
