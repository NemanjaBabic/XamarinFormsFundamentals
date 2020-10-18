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
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();

            //var layout = new AbsoluteLayout();
            //Content = layout;

            //var aquaBox = new BoxView { Color = Color.Aqua };
            //layout.Children.Add(aquaBox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);

            //var whiteBox = new BoxView { Color = Color.White };
            //layout.Children.Add(whiteBox, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.PositionProportional);

            ////AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1)); //// Setting bounds after initialization.
            ////AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional); //// Setting flags after initalization.
        }
    }
}