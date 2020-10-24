using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsFundamentals.Models;

namespace XamarinFormsFundamentals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<ContactGroup> contacts;

        ObservableCollection<ContactGroup> GetContactGroup(string searchText = null)
        {
            var contactGroup =  new ObservableCollection<ContactGroup>
            {
                new ContactGroup ("J","J")
                {
                    new Contact { Name = "John", Image = ImageSource.FromFile("avatar1.png") },
                    new Contact { Name = "Julia", Image = ImageSource.FromFile("avatar2.png"), Status= "Online" },
                },
                new ContactGroup("M", "M")
                {
                    new Contact { Name = "Mia", Image = ImageSource.FromResource("XamarinFormsFundamentals.Images.avatar3.png"), Status= "Offline" },
                },
                new ContactGroup("S", "S")
                {
                    new Contact { Name = "Steve", Image = ImageSource.FromResource("XamarinFormsFundamentals.Images.avatar4.png"), Status= "Busy" }
                }
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return contactGroup;
            return new ObservableCollection<ContactGroup>(contactGroup.Where(g => g.Title.StartsWith(searchText, StringComparison.CurrentCultureIgnoreCase)));
        }

        public ListPage()
        {
            InitializeComponent();

            //var items = new List<string>
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3"
            //};

            // Platform specific images (AndroidResource): avatar1 and avatar2
            // Embedded Images (Embedded resource): avatar3 and avatar4

            this.contacts = this.GetContactGroup();

            this.listView.ItemsSource = this.contacts;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contactGroup = e.Item as Contact;
            DisplayAlert("Tapped", contactGroup.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //this.listView.SelectedItem = null;
            var contactGroup = e.SelectedItem as Contact;
            DisplayAlert("Selected", contactGroup.Name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            if (contact.Name.StartsWith(this.contacts[0].Title, StringComparison.OrdinalIgnoreCase))
            {
                this.contacts[0].Remove(contact);
            }
            else if(contact.Name.StartsWith(this.contacts[1].Title, StringComparison.OrdinalIgnoreCase))
            {
                this.contacts[1].Remove(contact);
            }
            else if(contact.Name.StartsWith(this.contacts[2].Title, StringComparison.OrdinalIgnoreCase))
            {
                this.contacts[2].Remove(contact);
            }
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            this.contacts = this.GetContactGroup();
            this.listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.listView.ItemsSource = GetContactGroup(e.NewTextValue);
        }
    }
}