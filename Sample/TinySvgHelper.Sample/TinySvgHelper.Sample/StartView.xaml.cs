using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TinySvgHelper.Sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartView : ContentPage
    {
        public StartView()
        {
            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Info",
                IconImageSource = SvgHelper.GetAsImageSource("info.svg", 22, 22, Color.Default)
            }); ;
        }
    }
}