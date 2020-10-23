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
    public partial class ImageGalleryPage : ContentPage
    {
        public ImageGalleryPage()
        {
            InitializeComponent();
            this.image.Source = "image1.png";
        }

        private void Button_Clicked_Left(object sender, EventArgs e)
        {
            if (this.image.Source is FileImageSource source)
                switch (source.File)
                {
                    case "image1.png":
                        this.image.Source = "image3.png";
                        break;
                    case "image2.png":
                        this.image.Source = "image1.png";
                        break;
                    case "image3.png":
                        this.image.Source = "image2.png";
                        break;
                }
        }

        private void Button_Clicked_Right(object sender, EventArgs e)
        {
            if (this.image.Source is FileImageSource source)
                switch (source.File)
                {
                    case "image1.png":
                        this.image.Source = "image2.png";
                        break;
                    case "image2.png":
                        this.image.Source = "image3.png";
                        break;
                    case "image3.png":
                        this.image.Source = "image1.png";
                        break;
                }
        }
    }
}