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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            var imageSource = new UriImageSource { Uri = new Uri("https://via.placeholder.com/300x250?text=300x250+MPU") };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
        }
    }
}