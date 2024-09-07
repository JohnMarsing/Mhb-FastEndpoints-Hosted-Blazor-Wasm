namespace MyHebrewBible.Client.Features.VerseList.Enums;

public enum Status
{
	Private, // The VerseList can not be seen by anyone except the authors
	Public,  // The VerseList has been promoted can not be seen by anyone except the authors
	PromotedToMhbBaseContent // Now incorporated into the core knowledge base of MHB.
}
