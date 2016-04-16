using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnApretame_Click(object sender, RoutedEventArgs e)
        {
            this.lblTexto.Content = "Hola Mundo!";
        }
        
        private void btnBD_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=FACUNDO-PC;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", conn);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dg_bd.ItemsSource = DS.Tables[0].DefaultView;
            conn.Close();


        }
    }
}
