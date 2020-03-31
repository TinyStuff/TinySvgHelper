# TinySvgHelper
TinySvgHelper is a library that makes it easier to use svg images in your Xamarin.Forms app.

## Get started with TinySvgHelper
The library is published to NuGet, https://www.nuget.org/packages/TinySvgHelper/

To install it, search for TinySvgHelper in the **Nuget Package Manager** or install it with the following command:
```powershell
Install-Package TinySvgHelper
```

To use it you must add SvgHelper.Init() to your MainActivity and/or AppDelegate.

### MainActivity
```csharp
protected override void OnCreate(Bundle savedInstanceState)
{
    ....
    
    SvgHelper.Init();
    
    ...
}
```

### AppDelegate
```csharp
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    ...
    
    SvgHelper.Init();
    
    ...
}
```

## Use TinySvgHelper
You can use TinySvgHelper either from your XAML- or C# code. For iOS add the svg files to the **Resources** folder and for Android add the svg files to the **Assets** folder.

### XAML
First you need to import the namespace:
```xaml
xmlns:svg="clr-namespace:TinySvgHelper;assembly=TinySvgHelper"
```

Then you will use it as a markup extension:
```xaml
<Image Source="{svg:Svg FileName='logo.svg', Height=200,Width=200}" />
```

You can also specify a color to it: 
```xaml
<ShellContent Icon="{svg:Svg FileName='info.svg', Height=22,Width=22,Color=Black}" Title="Start">
    <views:StartView />
</ShellContent>
```

### C#
```csharp
using TinySvgHelper;
```

```csharp
var image = new Image();
image.Source = SvgHelper.GetAsImageSource("info.svg", 50, 50, Color.Blue);
```
