using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFundamentals.Models;

namespace XamarinFormsFundamentals.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : MasterDetailPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact> {
                    new Contact { Name = "John", Image = ImageSource.FromFile("avatar1.png") },
                    new Contact { Name = "Lucie", Image = ImageSource.FromFile("avatar2.png"), Status= "Online" },
            };
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            this.Detail = new NavigationPage(new ContactDetailPage(contact));
            listView.SelectedItem = null;
            this.IsPresented = false;
        }
    }
}