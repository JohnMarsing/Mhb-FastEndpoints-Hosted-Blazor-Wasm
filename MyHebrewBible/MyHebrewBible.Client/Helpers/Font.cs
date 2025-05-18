namespace MyHebrewBible.Client.Helpers;


/*
```csharp
@using MyHebrewBible.Client.Helpers
 (userSetting.OnState) ? Icon.Toggle.On : Icon.Toggle.Off;
```

```html
<i class='@Icon'></i> @Opposite
```

*/

public static class Icon
{
	public static class Toggle
	{
		public const string On = " fas fa-toggle-on";
		public const string Off = " fas fa-toggle-off";
		public static string Get(bool isOn) => isOn ? Toggle.On : Toggle.Off;
	}

	public static class Chevron
	{
		public const string Down = " fas fa-chevron-down";
		public const string Up = " fas fa-chevron-up";
		public static string Get(bool isDown) => isDown ? Chevron.Down : Chevron.Up;
	}


	public static class Size
	{
		public const string OneX = "";
		public const string TwoX = " fa-fw fa-2x";
		public const string ThreeX = " fa-fw fa-3x";
	}	

}
