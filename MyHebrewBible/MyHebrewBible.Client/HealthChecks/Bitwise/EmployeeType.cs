using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.HealthChecks.Bitwise;

public abstract class EmployeeType : SmartFlagEnum<EmployeeType>
{
	public static readonly EmployeeType Director = new DirectorType();
	public static readonly EmployeeType Manager = new ManagerType();
	public static readonly EmployeeType Assistant = new AssistantType();

	private EmployeeType(string name, int value) : base(name, value)
	{
	}

	public abstract decimal BonusSize { get; }

	private sealed class DirectorType : EmployeeType
	{
		public DirectorType() : base("Director", 1) { }
		public override decimal BonusSize => 100_000m;
	}

	private sealed class ManagerType : EmployeeType
	{
		public ManagerType() : base("Manager", 2) { }
		public override decimal BonusSize => 10_000m;
	}

	private sealed class AssistantType : EmployeeType
	{
		public AssistantType() : base("Assistant", 4) { }
		public override decimal BonusSize => 1_000m;
	}
}
