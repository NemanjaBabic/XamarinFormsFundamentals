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
    public partial class PickerPage : ContentPage
    {
        private IList<ContactMethod> contactMethod;

        public PickerPage()
        {
            InitializeComponent();

            this.contactMethod = this.GetContactMethods();

            foreach (var method in contactMethod)
                this.contactMethods2.Items.Add(method.Name);
        }

        private void Picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = this.contactMethods1.Items[this.contactMethods1.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "OK");
        }

        private void Picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = this.contactMethods2.Items[this.contactMethods2.SelectedIndex];
            var contactMethod = this.contactMethod.Single(cm => cm.Name == name);

            DisplayAlert("Selection", contactMethod.Id + " : " + name, "OK");
        }

        public class ContactMethod
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod {Id = 1, Name = "SMS"},
                new ContactMethod {Id = 2, Name = "Email"},
            };
        }
    }
}