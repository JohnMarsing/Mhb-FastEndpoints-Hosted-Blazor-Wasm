﻿using System.ComponentModel.DataAnnotations;

namespace MyHebrewBible.Client.Features.Articles.Search;

public class GreekStrongsFormVM
{
	[Range(1, 5624, ErrorMessage = "Greek Strong's must be between 1 and 5624.")]
	public int Number { get; set; } // = 1;
}
