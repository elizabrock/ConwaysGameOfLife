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
        public List<List<bool>> Cells { get; set; }
        private Board currentBoard;

        public MainWindow()
        {
            currentBoard = new FauxGameOfLife();
            Cells = currentBoard.ToList();

            InitializeComponent();
            TheListView.ItemsSource = Cells;
        }
    }
}
