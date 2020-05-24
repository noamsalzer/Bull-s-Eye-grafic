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
        int currRaw = 0;

        public GameWindow()
        {
            InitializeComponent();
            BuildFirstRaw();
            Buttons();
        }

        private void Buttons()
        {
            // שימו לב שפעולה זו לא עושה כלום. אתם תסבירו לי למה
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
            myRaw.Background = Brushes.Black;
            for (int i = 0; i < 4; i++)
            {
                Ellipse eli = new Ellipse();
                eli.Name = "eli" + (i+1);
                eli.Width = 30;
                eli.Height = 30;
                eli.MouseDown += ChoseColorClick;
                eli.Fill = Brushes.Gray;
                eli.Margin = new Thickness(10);
                myRaw.Children.Add(eli);
            }
            currRaw = 0;

            Button checkIt = CreateCheckItButton();
            Button clearRaw = CreateClearButton();

            myRaw.Children.Add(checkIt);
            myRaw.Children.Add(clearRaw);
            MyBoard.Children.Add(myRaw);
        }

        private Button CreateClearButton()
        {
            Button clear = new Button();
            // create your button
            return clear;
        }

        private Button CreateCheckItButton()
        {
            Button checkIt = new Button();
            checkIt.Width = 100;
            checkIt.Height = 30;
            checkIt.Margin = new Thickness(30, 5, 0, 0);
            checkIt.Background = Brushes.White;
            checkIt.Content = "Check";
            checkIt.FontSize = 20;
            checkIt.Foreground = Brushes.Black;
            checkIt.FontWeight = FontWeights.Bold;
            checkIt.Click += CheckIt_Click;
            return checkIt;
        }

        
        private void CheckIt_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChoseColorClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            StackPanel s = (StackPanel)MyBoard.Children[currRaw];
            for (int i = 0; i < 4; i++)
            {
                Ellipse el = (Ellipse)s.Children[i];
                if (el.Fill == Brushes.Gray)
                {
                    el.Fill = Brushes.Yellow;
                    Yellow.IsEnabled = false;
                    break;
                }
            }
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            StackPanel s = (StackPanel)MyBoard.Children[currRaw];
            for (int i = 0; i < 4; i++)
            {
                Ellipse el = (Ellipse)s.Children[i];
                if (el.Fill == Brushes.Gray)
                {
                    el.Fill = Brushes.Green;
                    Green.IsEnabled = false;
                    break;
                }
            }
        }
    }
}
