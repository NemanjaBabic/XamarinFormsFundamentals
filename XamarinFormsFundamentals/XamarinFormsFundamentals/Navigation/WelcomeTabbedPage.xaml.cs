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
    public partial class WelcomeTabbedPage : TabbedPage
    {
        public WelcomeTabbedPage()
        {
            InitializeComponent();
            //this.Children.Add(new ContentPage());
            //this.Children.Add(new NavigationPage(new ContentPage()));
            //this.Children.Add(new ContactsPage());
        }
    }
}