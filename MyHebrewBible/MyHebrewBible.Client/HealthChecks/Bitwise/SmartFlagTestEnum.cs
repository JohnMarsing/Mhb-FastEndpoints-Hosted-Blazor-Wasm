using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.HealthChecks.Bitwise;

public class SmartFlagTestEnum : SmartFlagEnum<SmartFlagTestEnum>
{
	//public static readonly SmartFlagTestEnum All = new SmartFlagTestEnum(nameof(All), -1);
	public static readonly SmartFlagTestEnum None = new SmartFlagTestEnum(nameof(None), 0);
	public static readonly SmartFlagTestEnum Card = new SmartFlagTestEnum(nameof(Card), 1);
	public static readonly SmartFlagTestEnum Cash = new SmartFlagTestEnum(nameof(Cash), 2);
	public static readonly SmartFlagTestEnum CardAndCash = new SmartFlagTestEnum(nameof(CardAndCash), 3); // Explicit `Combination` value
	public static readonly SmartFlagTestEnum Bpay = new SmartFlagTestEnum(nameof(Bpay), 4);
	public static readonly SmartFlagTestEnum Paypal = new SmartFlagTestEnum(nameof(Paypal), 8);
	public static readonly SmartFlagTestEnum BankTransfer = new SmartFlagTestEnum(nameof(BankTransfer), 16);

	public SmartFlagTestEnum(string name, int value) : base(name, value)
	{
	}
}