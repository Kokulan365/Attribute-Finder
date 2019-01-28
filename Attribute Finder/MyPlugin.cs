using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace AttributeFinder
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Attribute Finder"),
        ExportMetadata("Description", "This plugin allows you to search attributes across all system and custom entities"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", null),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", null),
                ExportMetadata("Author", "Kokulan"),

        ExportMetadata("BackgroundColor", "#571360"),
        ExportMetadata("PrimaryFontColor", "White"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }
    }
}