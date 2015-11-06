using System.Collections.Generic;
using System.Linq;
using System.Windows;
using ConwaysGameOfLife;

namespace BoardViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Board currentBoard;

        public MainWindow()
        {
            currentBoard = new FauxGameOfLife();

            InitializeComponent();
            TheListView.ItemsSource = currentBoard.ToList();
        }

        private void InitiateTick()
        {
            currentBoard.Tick();
            TheListView.ItemsSource = currentBoard.ToList();
        }

        private void Tick_Button_Click(object sender, RoutedEventArgs e)
        {
            InitiateTick();
        }

        private void Run_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
