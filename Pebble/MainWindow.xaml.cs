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
            string path = @"c:\users\yousha arif\documents\visual studio 2012\projects\pebble\pebble\files\namesofsurah.txt";
            string[] nameofsurah = System.IO.File.ReadAllLines(path);
            foreach (string line in nameofsurah)
            {
               // var image = new Image();
                //var bitimage = new bitmapimage();
                //bitimage.begininit();
                char[] c = {' '};
                String [] word = line.Split(c);
                var item = new SurahListItem();
                item.Surah = word[0];
                item.Verse = word[1];
                item.Ruku = word[2];
             //   try
            //    {
                    //bitimage.urisource = new uri("images/picb.png", urikind.relative);
                    //bitimage.endinit();
                    //image.stretch = stretch.uniformtofill;
                    //image.source = bitimage;
               //     item.Icon = "Images/picb.png";
                //}
               // catch { }
                ItemsControl.Items.Add(item);
            }
        }

         private void Image_MouseMove_1(object sender, MouseEventArgs e)
         {
             double x = e.GetPosition(this).X;
             double y = e.GetPosition(this).Y;
           //  this.Text1.Text = x + ", " + y;
            
         }
      

    }
}
