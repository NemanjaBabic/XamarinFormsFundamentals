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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            //var label1 = new Label { Text = "Label 1", BackgroundColor = Color.Silver };
            //var label2 = new Label { Text = "Label 2", BackgroundColor = Color.Silver };
            //var label3 = new Label { Text = "Label 3", BackgroundColor = Color.Silver };
            //var label4 = new Label { Text = "Label 4", BackgroundColor = Color.Silver };
            //var label5 = new Label { Text = "ColumnSpan", BackgroundColor = Color.Silver };
            //var label6 = new Label { Text = "RowSpan", BackgroundColor = Color.Silver };

            //Grid grid = new Grid { BackgroundColor = Color.Yellow , ColumnSpacing = 20, RowSpacing = 20 };

            //grid.Children.Add(label1, 0, 0);
            //grid.Children.Add(label2, 0, 1);
            //grid.Children.Add(label3, 1, 0);
            //grid.Children.Add(label4, 1, 1);
            //grid.Children.Add(label5, 0, 2);
            //grid.Children.Add(label6, 2, 0);

            //Grid.SetColumnSpan(label5, 3);
            //Grid.SetRowSpan(label6, 3);

            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) });
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            //grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //Content = grid;
        }
    }
}