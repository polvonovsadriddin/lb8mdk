using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mdk_lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {private LinkedList<int>linked= new LinkedList<int>();
        Random r= new Random();
        public MainWindow()
        {
            InitializeComponent();
            linked= new LinkedList<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for(var i = 0; i<10; i++)
            {
                linked.AddLast(r.Next(1, 10));

            }
            lblinked.ItemsSource = linked;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int multi = 1;
            foreach(var err in linked)
            {
                if (err%2==0)
                {
                    multi*= err;
                }
            }
            tbresult.Text = $"Полученный элемент: {multi}";
            linked.AddLast(multi);

            lblinked.ItemsSource = null; // устанавливаем источник данных в null
            lblinked.ItemsSource = linked;

        }
    }
}