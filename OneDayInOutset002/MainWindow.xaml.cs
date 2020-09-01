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

namespace OneDayInOutset002
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CreateLoc run = new CreateLoc();
            run.Loc0 = new Loc(name = LocInfo.Loc0Name, desc = LocInfo.Loc0Desc);
            //run.Startup();
            InitializeComponent();
            DataContext = run.Loc0;
        }
    }
}