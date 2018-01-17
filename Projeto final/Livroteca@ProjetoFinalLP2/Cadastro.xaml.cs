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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Livroteca_ProjetoFinalLP2
{
    /// <summary>
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=(localdb)\higa_sqlserver;Initial Catalog=LivrotecaBD;Integrated Security=SSPI;")

            };

            string usu, senha, nome, rg, mail, nasc, endereco, cpf;
         
            usu = registroUser.Text;
            senha = registroSenha.Password;
            nome = registroNome.Text;
            rg = registroRG.Text;
            mail = registroMail.Text;
            nasc = registroNasc.Text;
            endereco = registroEnd.Text;
            cpf = registroCPF.Text;

            if (registroUser.Text == "" || registroSenha.Password == "" || registroNome.Text == "" || registroRG.Text == "" || registroMail.Text == "" || registroNasc.Text == "" || registroEnd.Text == "" || registroCPF.Text == "")
            {
                MessageBox.Show("Insira os seus dados nas caixas de texto.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    DadosClientes d = new DadosClientes();
                    d.EnviarParaBD(usu, nasc, nome, rg, mail, senha, endereco, cpf);
                    if (d.cadastrook == true)
                    {
                        MainWindow telaLogin = new MainWindow();
                        this.Close();
                        telaLogin.Show();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Ocorreu um erro ao enviar seus dados para o servidor, por favor verificar os dados inseridos. ", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }     
        }
    }
}