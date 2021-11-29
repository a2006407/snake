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
using System.Windows.Threading;

namespace M09SnakeGit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {


        SnakeGame jocSerp;


        public MainWindow() {
            jocSerp = new SnakeGame();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            int casellaXsize = (int)(canvas.ActualWidth / SnakeGame.X_SIZE);
            int casellaYsize = (int)(canvas.ActualWidth / SnakeGame.Y_SIZE);
            Ellipse elipSerp = new Ellipse() {
                Fill = Brushes.Green,
                Width = canvas.ActualWidth / SnakeGame.X_SIZE,
                Height = canvas.ActualHeight / SnakeGame.Y_SIZE
            };

            canvas.Children.Add(elipSerp);
            Canvas.SetTop(elipSerp, jocSerp.CapSerp.X * casellaXsize);
            Canvas.SetLeft(elipSerp, jocSerp.CapSerp.Y * casellaYsize);

        }

        private void canvas_KeyDown(object sender, KeyEventArgs e) {
            if(e.Key is Key.Down) {
                jocSerp.moure();
            }

        }
    }
}
