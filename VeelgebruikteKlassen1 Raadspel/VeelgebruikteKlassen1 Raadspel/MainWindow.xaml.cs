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

namespace VeelgebruikteKlassen1_Raadspel
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int randomNumber;
        int counter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int inputNumber);

            if (inputNumber < randomNumber)
            {
                counter++;
                output1TextBox.Text = "Raad Hoger";
            }
            if (inputNumber > randomNumber)
            {
                counter++;
                output1TextBox.Text = "Raad lager";
            }
            if (inputNumber==randomNumber){
                output1TextBox.Text = "Proficiat! U hebt het getal geraden";
                output2TextBox.Text = $"Aantal keren geraden: {counter}";

            }
        }
        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            var random= new Random();
            randomNumber = random.Next(0, 100);
            counter = 0;
        }
    }
}