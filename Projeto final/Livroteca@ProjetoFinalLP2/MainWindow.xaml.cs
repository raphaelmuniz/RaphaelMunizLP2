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
using System.Data.SqlClient;

namespace Livroteca_ProjetoFinalLP2
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
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            Cadastro telaCadastro = new Cadastro();
            this.Close();
            telaCadastro.Show();

        }
        public static string usubd, senhabd;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string usu, senha;

                usu = loginUsu.Text;
                senha = loginSenha.Password;

                SqlConnection conexao = new SqlConnection(@"Data Source=(localdb)\higa_sqlserver;Initial Catalog=LivrotecaBD;Integrated Security=SSPI;");              
                SqlCommand verificar = new SqlCommand(@"SELECT
                                                      COUNT (*) FROM Cliente WHERE usu=@usu AND senha=@senha", conexao);
                verificar.Parameters.Clear();
                verificar.Parameters.AddWithValue("@usu", loginUsu.Text);
                verificar.Parameters.AddWithValue("@senha", loginSenha.Password);
                conexao.Open();

                if(verificar.ExecuteScalar().ToString()=="1")
                {
                   MessageBox.Show("Bem-Vindo à Livroteca, " + loginUsu.Text + "!", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
                   Menu loginMenu = new Menu();
                   this.Close();
                   loginMenu.Show();
                }
                else
                {
                    if (loginUsu.Text == "" || loginSenha.Password == "")
                    {
                        MessageBox.Show("Insira os suas credenciais para entrar no sistema", "Erro no Login", MessageBoxButton.OK, MessageBoxImage.Error);
                        loginUsu.Clear();
                        loginSenha.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Suas credenciais estão incorretas. Por favor verifique-as.", "Erro no Login", MessageBoxButton.OK, MessageBoxImage.Error);
                        loginUsu.Clear();
                        loginSenha.Clear();
                    }               
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
               
        
        public class DadodoLivro 
        { 
            public string Titulo { get; set; } 
            public double Preco { get; set; } 
            public string Autor { get; set; }
            public string Genero{ get; set; }
            public string Disponibilidade {get;set;}


        }
        private List<Livros> ObterLista(string Buscar) 
        { 
            SqlConnection conexao  = new SqlConnection(@"Data Source=(localdb)\higa_sqlserver;Initial Catalog=LivrotecaBD;Integrated Security=SSPI;"); 
       
            List<DadodoLivro> lista = new List<DadodoLivro>(); 
            string query = "SELECT Titulo,Preco,Disponibilidade,Autor,Genero FROM Livros WHERE Nome LIKE '%" + Buscar + "%'"; 
           
            SqlCommand cmd = new SqlCommand(query, conexao); 
            conn.Open();  
            SqlDataReader leitor = cmd.ExecuteReader(); 
            if (leitor.HasRows) 
            { 
              
                while (leitor.Read()) 
                { 
                    DadodoLivro L = new DadodoLivro(); 
                    L.Titulo = leitor["Titulo"].ToString();
                    L.Preco = double.Parse(leitor["Preco"]);
                    L.Disponibilidade = leitor["Disponibilidade"].ToString();
                    L.Autor = leitor ["Autor"].ToString();
                    L.Genero = Leitor ["Genero"].ToString();

                    lista.Add(L); 
                } 
            } 
            conn.Close();  
            return lista; 
        } 
 
        private void Form1_Load(object sender, EventArgs e) 
        { 
            dgvClientes.DataSource = ObterLista(txtBuscar.Text); 
            // MOSTRA LISTA NA TELA
        } 

 
        private void btnBuscar_Click(object sender, EventArgs e) 
        {  
            dgvClientes.DataSource = ObterLista(txtBuscar.Text); 
            // Gera lista
        } 
        
        }
        }
    

