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
            //btn.Height = 110;
            btn.Background = Brushes.Brown;
            btn.Margin = new Thickness(0, 350, 0, 0);

            WrapPanel miWrap = new WrapPanel();

            Grid.SetColumn(miWrap, 1);

            TextBlock textBlock1 = new TextBlock();

            textBlock1.Background = Brushes.BurlyWood;
            textBlock1.Foreground = Brushes.Brown;
            textBlock1.FontSize = 20;

            textBlock1.Text = "Click";

            miWrap.Children.Add(textBlock1);

            TextBlock textBlock2 = new TextBlock();

            textBlock2.Background = Brushes.BurlyWood;
            textBlock2.Foreground = Brushes.Brown;
            textBlock2.FontSize = 20;

            textBlock2.Text = "Enviar";

            miWrap.Children.Add(textBlock2);

            TextBlock textBlock3 = new TextBlock();

            textBlock3.Background = Brushes.BurlyWood;
            textBlock3.Foreground = Brushes.Brown;
            textBlock3.FontSize = 20;

            textBlock3.Text = "Dale";

            miWrap.Children.Add(textBlock3);

            btn.Content = miWrap;

            miGrid.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Le has dado al botón de nuevo");
            Console.WriteLine("Le has dado al boton 2!!");
        }

        /*
        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al panel");
        }
        */

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al panel");
        }
    }
}
