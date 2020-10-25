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
    public partial class HierarchicalNavigationWelcomePage : ContentPage
    {
        public HierarchicalNavigationWelcomePage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new HierarchicalNavigationIntroductionPage());
        }
    }
}