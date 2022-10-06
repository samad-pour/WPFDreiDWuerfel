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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDreiDWuerfel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.V)
            {
                Oc.Position = new Point3D(1, 3, 5);
                Oc.LookDirection = new Vector3D(-1, -3, -5);
                Dl.Direction = new Vector3D(-1, -3, -5);
                Title = "WPFDreiDWuerfel, von vorne";
            }
            else if (e.Key == Key.H)
            {
                Oc.Position = new Point3D(-1, -3, -5);
                Oc.LookDirection = new Vector3D(1, 3, 5);
                Dl.Direction = new Vector3D(1, 3, 5);
                Title = "WPFDreiDWuerfel, von hinten";
            }
        }
    }
}
