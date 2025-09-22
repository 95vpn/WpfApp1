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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid miGrid = new Grid();

            //this.Content = miGrid;

            Button btn = new Button();
            btn.Width = 250;
            btn.Height = 110;
            btn.Margin = new Thickness(50, 200, 0, 0);

            WrapPanel miWrap = new WrapPanel();

            TextBlock textBlock1 = new TextBlock();

            textBlock1.Text = "Click";

            miWrap.Children.Add(textBlock1);

            TextBlock textBlock2 = new TextBlock();

            textBlock2.Text = "Enviar";

            miWrap.Children.Add(textBlock2);

            TextBlock textBlock3 = new TextBlock();

            textBlock3.Text = "Dale";

            miWrap.Children.Add(textBlock3);

            btn.Content = miWrap;

            miGrid.Children.Add(btn);
        }

        

        
    }
}
