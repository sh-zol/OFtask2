using System.Data;
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

namespace OFtask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = InputTextBox.Text;
                var result = EvaluateExpression(input);
                ResultTextBlock.Text = "Result " + result.ToString();
            }
            catch(Exception ex)
            {
                ResultTextBlock.Text = ex.Message;
            }
        }

        public double EvaluateExpression(string expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, string.Empty);
            return Convert.ToDouble(value);
        }
    }
}