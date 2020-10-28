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
    public partial class StepperPage : ContentPage
    {
        public StepperPage()
        {
            InitializeComponent();
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newValue = e.NewValue;
            var oldValue = e.OldValue;
        }
    }
}