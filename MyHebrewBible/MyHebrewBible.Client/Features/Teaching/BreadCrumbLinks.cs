using Microsoft.AspNetCore.Components;

namespace MyHebrewBible.Client.Features.Teaching.BreadCrumbLinks;


// /Teaching/
//public static class Teaching
//{
//}	

public static class Parent
{
	public const string Index = "Teaching";
	public const string Title = "Teaching";
	public const string Icon = "fas fa-table";
}

public static class TwoHouse
{
	public const string Index = $"{Parent.Index}/TwoHouse";
	public const string Title = "Two House";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fa fa-number-two'></i><i class='fa fa-letter-bet'></i><i class='fa fa-number-one'></i><i class='fa fa-letter-tav'></i>";
	public const int SortOrder = 1;
}

public static class CovenantsAndContracts
{
	public const string Index = $"{Parent.Index}/CovenantsAndContracts";
	public const string Title = "Covenants and Contracts";
	public const string Icon = "fas fa-table";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fa fa-letter-tav fa-2x'></i>";
	public const int SortOrder = 2;
}

public static class BiblicalBanking
{
	public const string Index = $"{Parent.Index}/BiblicalBanking";
	public const string Title = "Biblical Banking";
	public const string Icon = "fas fa-table";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fas fa-university fa-2x'></i>";
	public const int SortOrder = 3;
}

public static class TorahGatedCommunity
{
	public const string Index = $"{Parent.Index}/TorahGatedCommunity";
	public const string Title = "Torah Gated Community";
	public const string Icon = "fas fa-table";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fas fa-church fa-2x'></i>";
	public const int SortOrder = 4;
}

public static class ConservatismFailure
{
	public const string Index = $"{Parent.Index}/ConservatismFailure";
	public const string Title = "Conservatism Failure";
	public const string Icon = "fas fa-table";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fas fa-ban fa-2x'></i>";
	public const int SortOrder = 5;
}

public static class MarsingsRules
{
	public const string Index = $"{Parent.Index}/MarsingsRules";
	public const string Title = "Marsing's Rules";
	public const string Icon = "fas fa-table";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fas fa-ruler fa-2x'></i>";
	public const int SortOrder = 6;
}

public static class Identity
{
	public const string Index = $"{Parent.Index}/Identity";
	public const string Title = "Identity";
	public const string Icon = "fas fa-table";
	public static MarkupString IconMarkup = (MarkupString)"<i class='fas fa-hand-point-right fa-2x'></i>";
	public const int SortOrder = 7;
}
