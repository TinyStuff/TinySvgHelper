﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TinySvgHelper.Sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutView : ContentPage
    {
        public AboutView()
        {
            InitializeComponent();

            Icon.Source = TinySvgHelper.SvgHelper.GetAsImageSource("info.svg", 50, 50, Color.Blue);
        }
    }
}