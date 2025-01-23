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
using System.Diagnostics;


namespace MyClassWindowProject
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car myCar;
        //Car object

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreateCar_Click(object sender, RoutedEventArgs e)
        {
            myCar = new Car();

            myCar.Make = txtMake.Text;
            myCar.Colour = txtColour.Text;

            // Set car properties from textboxes
            myCar.Make = txtMake.Text;
            myCar.Colour = txtColour.Text;
            myCar.Type = txtType.Text;
            myCar.Cost = double.Parse(txtCost.Text);
            // Note: Country is read-only, so we don't set it

            Debug.WriteLine(
                "Car created"
                + "\nMake: " + myCar.Make
                + "\nColour: " + myCar.Colour
                + "\nType: " + myCar.Type
                + "\nCountry: " + myCar.Country
                + "\nCost: " + myCar.Cost);

            Console.ReadLine();

        }

        private void BtnClearContents_Click(object sender, RoutedEventArgs e)
        {
            txtColour.Text = "";
            txtMake.Text = "";
            txtType.Text = "";
            txtCountry.Text = "";
            txtCost.Text = ""
            ;
        }

        private void BtnGetLastCar_Click(object sender, RoutedEventArgs e)
        {
            txtMake.Text = myCar.Make;
            txtColour.Text = myCar.Colour;
            txtType.Text = myCar.Type;
            txtCountry.Text = myCar.Country;
            txtCost.Text = myCar.Cost.ToString();
        }
    }
}
