namespace MyHebrewBible.Client.HealthChecks.Bitwise;

[Flags]
public enum UserType
{
	None = 0,
	Customer = 1,
	Driver = 2,
	Admin = 4,
	Employee = Driver | Admin
}