using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsFundamentals.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HierarchicalNavigationIntroductionPage : ContentPage
    {
        public HierarchicalNavigationIntroductionPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true; // disables the back button functionality (only present in Android and Windows phones).

            ////return base.OnBackButtonPressed(); // default behavior, takes by the user to the previous step.
        }
    }
}