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

namespace labsheet1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band.RockBand r1 = new Band.RockBand("Nirvana", 1991, "Kurt");
            Band.PopBand p1 = new Band.PopBand("Imagine dragons", 2001, "Henry");
            Band.IndieBand i1 = new Band.IndieBand("Arctic Monkeys", 1980, "James Hetfield");
            Band.PopBand p2 = new Band.PopBand("One Direction", 2011, "kurt");
            Band.IndieBand i2 = new Band.IndieBand("Seven nation Army", 1985, "Dave Mustaine");
            Band.RockBand r2 = new Band.RockBand("Foo Fighters", 1999, "Dave Grohl");
            Band[] bandscreated = { r1, r2, p1, p2, i1, i2 };
       
            cboxgenre.ItemsSource = new string[] { "Rock", "Pop", "Indie" };
            lbxband.ItemsSource = bandscreated;
           // return bandscreated;


        }
    }
}
