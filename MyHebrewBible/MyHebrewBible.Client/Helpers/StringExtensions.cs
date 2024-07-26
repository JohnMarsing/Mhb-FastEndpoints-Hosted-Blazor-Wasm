namespace Client.Helpers;

public static class StringExtensions
{
	//ToDo: NOTE BEING USED
	public static string Truncate(this string value, int maxLength)
	{
		if (string.IsNullOrEmpty(value)) return value;
		return value.Length <= maxLength ? value : value.Substring(0, maxLength);
	}
	/*
	- C:\Users\JohnM\source\repos\LivingMessiahBlazor\LivingMessiah.Web\Infrastructure\StringExtensions.cs
	public static StringBuilder AppendWhen(
	public static StringBuilder AppendIf
	public static string Repeat
	public static string PhoneNumber
	*/
}
