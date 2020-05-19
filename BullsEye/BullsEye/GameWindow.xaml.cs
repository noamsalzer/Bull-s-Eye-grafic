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
using System.Windows.Shapes;

namespace BullsEye
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
            BuildFirstRaw();
             Buttons();
        }

        private void Buttons()
        {
            StackPanel myVertical = new StackPanel();
            myVertical.Orientation = Orientation.Vertical;
            for (int i = 0; i < 6; i++)
            {
                Button color = new Button();
                color.Name = "color" + (i + 1);
                color.Content = color.Name;
                color.Margin = new Thickness(20);
                myVertical.Children.Add(color);
            }
            
            
        }

        private void BuildFirstRaw()
        {
            StackPanel myRaw = new StackPanel();
            myRaw.Orientation = Orientation.Horizontal;
            for (int i = 0; i < 4; i++)
            {
                Button bt = new Button();
                bt.Name = "bt" + (i+1);
                bt.Content = bt.Name;
                bt.Margin = new Thickness(5);
                bt.Background = Brushes.Aqua;
                myRaw.Children.Add(bt);
            }
            MyBoard.Children.Add(myRaw);
        }

       
    }
}
