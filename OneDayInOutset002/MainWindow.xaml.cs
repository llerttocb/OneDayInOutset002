using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
        Construct con = new Construct();
        Game game = new Game();
        TimeSpan time = new TimeSpan(0, 0, 8);
        Button[] barray = new Button[6];
        public MainWindow()
        {
            con.Startup();
            InitializeComponent();
            ButtonArray();
            DataContext = con;
            ButtonClick(this, new RoutedEventArgs());
        }
        void ButtonArray()
        {
            barray[0] = Opt1;
            barray[1] = Opt2;
            barray[2] = Opt3;
            barray[3] = Opt4;
            barray[4] = Opt5;
            barray[5] = Opt6;
        }
        void Completed(object sender, EventArgs e)
        {
            Continue.Text = "Click to continue...";
        }
        void ButtonClick(object sender, RoutedEventArgs e)
        {
            Continue.Text = "";
            game.Typewriter(con.Startup1.text, MainText, time);
            game.story.Completed += new EventHandler(Completed);
            game.story.Begin(MainText, true);
            if (con.Startup1.choices.Count == 1)
            {
                con.Startup1 = con.Startup1.choices[0];
            }
            else
            {
                for (int i = 0; con.Startup1.choices.Count < i + 2; i++)
                {
                    barray[i].Visibility = Visibility.Visible;
                }
            }
        }
        void Skip(object sender, RoutedEventArgs e)
        {
            if (game.story.GetCurrentState(MainText) == ClockState.Active)
            {
                game.story.SkipToFill(MainText);
                return;
            }
            else
            {
                ButtonClick(this, e);
                return;
            }
        }
    }
}