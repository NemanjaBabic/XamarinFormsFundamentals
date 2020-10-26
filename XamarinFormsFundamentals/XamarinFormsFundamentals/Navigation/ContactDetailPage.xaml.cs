using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFundamentals.Models;

namespace XamarinFormsFundamentals.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            BindingContext = contact ?? throw new ArgumentNullException();

            InitializeComponent();
        }
    }
}