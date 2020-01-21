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
            /*     Player player5 = new Player(5, "Pauline", 0);
            //List part6
            List<Player> allPlayers = new List<Player>();*/
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Band b1 = new Band("Nirvana", 1991, "Kurt");
            Band b2 = new Band("Imagine dragons", 2001, "Henry");
            Band b3 = new Band("Mettallica", 1980, "James Hetfield");
            Band b4 = new Band("One Direction", 2011, "kurt");
            Band b5 = new Band("Megadeth", 1985, "Dave Mustaine");
            Band b6 = new Band("Foo Fighters", 1999, "Dave Grohl");


        }
    }
}
