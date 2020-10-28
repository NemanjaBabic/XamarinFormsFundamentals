using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsFundamentals.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateCell : ViewCell
    {
        /////////////////////////////////////////////////////////////////////////
        // How to create Bindable Property
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCell));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        /////////////////////////////////////////////////////////////////////////

        public DateCell()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}