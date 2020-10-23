using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsFundamentals.MarkupExtensions
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(this.ResourceId))
            {
                return null;
            }

            return ImageSource.FromResource(this.ResourceId);
        }
    }
}
