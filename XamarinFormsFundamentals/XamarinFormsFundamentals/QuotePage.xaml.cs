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
    public partial class QuotePage : ContentPage
    {
        private int counter = 0;

        private static string[] quotes = new string[]
        {
            "Quote 1",
            "Quote 2",
            "Quote 3",
            "Quote 4",
            "Quote 5",
        };

        public QuotePage()
        {
            InitializeComponent();
            this.quote.Text = quotes[this.counter++];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.quote.Text = quotes[this.counter++];
            this.counter = this.counter == 5 ? 0 : this.counter++;
        }
    }
}