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

namespace BullsEye
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

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow();
            gw.Show();
            this.Close();
        }

        private void howToPlayButton_Click(object sender, RoutedEventArgs e)
        {
            HowToPlayWindow htp = new HowToPlayWindow();
            htp.Show();
            this.Close();
        }

        private void levalsButoon_Click(object sender, RoutedEventArgs e)
        {
            LevelSelectionWindow ls = new LevelSelectionWindow();
            ls.Show();
            this.Close();
        }
    }
}
