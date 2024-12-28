using System.Text;

namespace MyHebrewBible.Client.Helpers;

public static class StringExtensions
{
	//ToDo: NOTE BEING USED
	public static StringBuilder AppendWhen(
		this StringBuilder sb, string value, bool predicate) => predicate ? sb.Append(value) : sb;


	//ToDo: NOTE BEING USED
	// See D:\TFS\OsisXmlToSql\BuildLetter\Helper\StringExtensions.cs
	public static StringBuilder AppendIf(
		this StringBuilder builder, bool condition, string value)
	{
		if (condition) builder.Append(value);
		return builder;
	}

	public static StringBuilder AppendIfElse(
		this StringBuilder builder, bool condition, string ifValue, string elseValue)
	{
		if (condition)
		{
			return builder.Append(ifValue);
		}
		else
		{
			return builder.Append(elseValue);
		}
	}
	

	//ToDo: NOTE BEING USED
	public static string Truncate(this string value, int maxLength)
	{
		if (string.IsNullOrEmpty(value)) return value;
		return value.Length <= maxLength ? value : value.Substring(0, maxLength);
	}
	/*
	public static string ReplaceFirstOccurrence(this string original, string oldValue, string newValue)
	{
		if (String.IsNullOrEmpty(original))
			return String.Empty;
		if (String.IsNullOrEmpty(oldValue))
			return original;
		if (String.IsNullOrEmpty(newValue))
			newValue = String.Empty;
		int loc = original.IndexOf(oldValue);
		return original.Remove(loc, oldValue.Length).Insert(loc, newValue);
	}

	public static string ReplaceLastOccurrence(this string source, string find, string replace)
	{
		int place = source.LastIndexOf(find);

		if (place == -1)
			return source;

		string result = source.Remove(place, find.Length).Insert(place, replace);
		return result;
	}

	public static string ReplaceFirstOccurrence(this string original, string oldValue, string newValue)
	{
		if (String.IsNullOrEmpty(original))
			return String.Empty;
		if (String.IsNullOrEmpty(oldValue))
			return original;
		if (String.IsNullOrEmpty(newValue))
			newValue = String.Empty;
		int loc = original.IndexOf(oldValue);
		return original.Remove(loc, oldValue.Length).Insert(loc, newValue);
	}

	public static string ReplaceLastOccurrence(this string source, string find, string replace)
	{
		int place = source.LastIndexOf(find);

		if (place == -1)
			return source;

		string result = source.Remove(place, find.Length).Insert(place, replace);
		return result;
	}

	public static int IndexOfNth(this string input,
															 string value, int startIndex, int nth)
	{
		if (nth < 1)
			throw new NotSupportedException("Param 'nth' must be greater than 0!");
		if (nth == 1)
			return input.IndexOf(value, startIndex);
		var idx = input.IndexOf(value, startIndex);
		if (idx == -1)
			return -1;
		return input.IndexOfNth(value, idx + 1, --nth);
	}

	public static bool In(this string value, params string[] stringValues)
	{
		foreach (string otherValue in stringValues)
			if (string.Compare(value, otherValue) == 0)
				return true;

		return false;
	}

	public static string Right(this string value, int length)
	{
		return value != null && value.Length > length ? value.Substring(value.Length - length) : value;
	}
	public static string Left(this string value, int length)
	{
		return value != null && value.Length > length ? value.Substring(0, length) : value;
	}
	public static string Format(this string value, object arg0)
	{
		return string.Format(value, arg0);
	}
	public static string Format(this string value, params object[] args)
	{
		return string.Format(value, args);
	}

https://github.com/Dotnet-Boxed/Framework/blob/master/Source/Boxed.AspNetCore.TagHelpers/StringBuilderExtensions.cs
 
 AppendMetaNameContent<T>(this StringBuilder stringBuilder, string name, T content)
 AppendMetaNameContentIfNotNull<T>(this StringBuilder stringBuilder, string name, T content)
 AppendMetaPropertyContent<T>(this StringBuilder stringBuilder, string property, T content)
 AppendMetaPropertyContent(this StringBuilder stringBuilder, string property, DateTime content)
 AppendMetaPropertyContent<T>(this StringBuilder stringBuilder, string property,  IEnumerable<T> content)
 AppendMetaPropertyContentIfNotNull<T>(this StringBuilder stringBuilder, string property, T content)
 AppendMetaPropertyContentIfNotNull(this StringBuilder stringBuilder, string property, DateTime? content)
 AppendMetaPropertyContentIfNotNull<T>(this StringBuilder stringBuilder, string property, IEnumerable<T> content)

	*/
}
