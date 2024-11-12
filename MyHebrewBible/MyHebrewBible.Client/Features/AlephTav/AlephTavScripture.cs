//using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.AlephTav;

public class AlephTavScripture
{
	public int ID { get; set; }
	public string? BCV { get; set; }
	public byte BookID { get; set; }
	public byte Chapter { get; set; }
	public byte Verse { get; set; }
	public string? VerseOffset { get; set; }
	public string? KJV { get; set; }
	public string? Hebrew2 { get; set; }
	public string? Interlinear { get; set; }
	public string? InterlinearKjv { get; set; }
	//[MaxLength(500)]
	public string? CommentsMD { get; set; }
}
