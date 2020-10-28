using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsFundamentals.FormsAndSettingPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SliderPage : ContentPage
    {
        public SliderPage()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newValue = e.NewValue;
            var oldValue = e.OldValue;
        }
    }
}