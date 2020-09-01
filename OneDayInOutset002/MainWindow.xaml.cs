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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OneDayInOutset002
{
    public partial class MainWindow
    {
        CreateLoc run = new CreateLoc();
        Game game = new Game();
        TimeSpan time = new TimeSpan(0, 0, 8);
        public MainWindow()
        {
            run.Startup();
            InitializeComponent();
            DataContext = run;
        }
        void ButtonClick(object sender, RoutedEventArgs e)
        {
            game.Typewriter(run.Loc0.desc, MainText, time);
        }
        void Skip(object sender, RoutedEventArgs e)
        {
            game.story.SkipToFill();
        }
    }
}