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
using MenuUserControls.UserControls;

namespace MenuUserControls
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


        private void home_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Home);
        }

        public void SetActiveUserControl(UserControl control)
        {
            //Collapse all user controls
            Home.Visibility = Visibility.Collapsed;
            News.Visibility = Visibility.Collapsed;
            Music.Visibility = Visibility.Collapsed;
            Games.Visibility = Visibility.Collapsed;

            //Make the selected control visible
            control.Visibility = Visibility.Visible;
        }


        private void menuHome_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Home);
        }

        private void menuNnews_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(News);
        }

        private void menuMusic_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Music);
        }

        private void menuGames_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Games);
        }

    }
}
