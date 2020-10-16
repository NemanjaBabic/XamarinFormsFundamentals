using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsFundamentals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();

            //var layout = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Center,
            //    HorizontalOptions = LayoutOptions.Center,
            //    Orientation = StackOrientation.Horizontal,
            //    Spacing = 20,
            //    Padding = new Thickness(40),
            //    BackgroundColor = Color.RosyBrown,
            //};
            //layout.Children.Add(new StackLayout { BackgroundColor = Color.Yellow });
            //((StackLayout)layout.Children.ElementAt(0)).Children.Add(new BoxView { Color = Color.Black });
            //((StackLayout)layout.Children.ElementAt(0)).Children.Add(new Label { Text = "Label 1", BackgroundColor = Color.GreenYellow });
            //layout.Children.Add(new Label { Text = "Label 2", BackgroundColor = Color.GreenYellow });
            //layout.Children.Add(new Label { Text = "Label 3", BackgroundColor = Color.GreenYellow });
            //Content = layout;
        }
    }
}