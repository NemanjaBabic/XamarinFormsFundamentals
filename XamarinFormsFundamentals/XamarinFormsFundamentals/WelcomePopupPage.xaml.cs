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
    public partial class WelcomePopupPage : ContentPage
    {
        public WelcomePopupPage()
        {
            InitializeComponent();
        }

        async private void Button1_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            if (response)
                await DisplayAlert("Done", "Your response will be saved!", "OK");
        }

        async private void Button2_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Response", response, "Ok");
        }
    }
}