using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pebble
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            String path = @"C:\Users\Yousha Arif\Documents\Visual Studio 2012\Projects\Pebble\Pebble\Files\NamesOfSurah.txt";
              String [] nameOfSurah = System.IO.File.ReadAllLines(path);
              foreach (String line in nameOfSurah)
              {
                  var image = new Image();
                  var Bitimage = new BitmapImage();
                  Bitimage.BeginInit();

                 var item = new SurahListItem();
                 //try{
                 //   Bitimage.UriSource = new Uri("images/Thing.png", UriKind.Relative);
                 //   Bitimage.EndInit();
                 //   image.Stretch = Stretch.UniformToFill;
                 //   image.Source = Bitimage;
                 //    }
                 // catch{}
                 ItemsControl.Items.Add(item);
              }
        }

         private void Image_MouseMove_1(object sender, MouseEventArgs e)
         {
             double x = e.GetPosition(this).X;
             double y = e.GetPosition(this).Y;
             this.Text1.Text = x + ", " + y;
            
         }
      

    }
}
