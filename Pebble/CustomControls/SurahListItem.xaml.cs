﻿using System;
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
    /// Interaction logic for SurahListItem.xaml
    /// </summary>
    public partial class SurahListItem : UserControl
    {
        public SurahListItem()
        {
            InitializeComponent();
        }
        public string Surah 
        {
            get { return this.NameOfSurah.Text; }
            set { this.NameOfSurah.Text = value;}
        }

        public string Verse 
        {
            get { return this.VerseNumber.Text; }
            set { this.VerseNumber.Text = value; }
        }

        public string Parah
        {
            get { return this.ParahNumber.Text; }
            set { this.ParahNumber.Text = value; }
        }

        public ImageSource Icon
        {
            get { return this.IconOfSurah.Source; }
            set { this.IconOfSurah.Source = value; }
        }
      
    }
}
