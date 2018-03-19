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

namespace RunClickRun
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public  void MouseMove(object sender, MouseEventArgs e)
        {
            
            if (RunButton.VerticalAlignment != VerticalAlignment.Top)
            {
                RunButton.VerticalAlignment = VerticalAlignment.Stretch;
            }
            else
            {
                RunButton.VerticalAlignment = VerticalAlignment.Top;
            }
            if (RunButton.HorizontalAlignment != HorizontalAlignment.Left)
            {
                RunButton.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else
            {
                RunButton.HorizontalAlignment = HorizontalAlignment.Right;
            }
        }
    }
}
