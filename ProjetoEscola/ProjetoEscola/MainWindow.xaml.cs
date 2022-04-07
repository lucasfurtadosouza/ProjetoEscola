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
using ProjetoEscola.Classes;

namespace ProjetoEscola
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txtNomeFantasia.Focus();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            Classes.Escola.NomeFantasia = txtNomeFantasia.Text;
            Classes.Escola.RazaoSocial = txtRazaoSocial.Text;
            Classes.Escola.CNPJ = txtCNPJ.Text;
            Classes.Escola.InscEstadual = txtInscEstudal.Text;
            Classes.Escola.Responsavel = txtResponsavel.Text;
            Classes.Escola.Rua = txtRua.Text;
            Classes.Escola.Numero = Convert.ToInt32(txtNumero.Text);
            Classes.Escola.Bairro = txtBairro.Text;
            Classes.Escola.Complemento = txtComplemento.Text;
            Classes.Escola.CEP = txtCep.Text;
            Classes.Escola.Cidade = txtCidade.Text;
            Classes.Escola.Estado = cbEstado.Text;
            Classes.Escola.Telefone = txtTelefone.Text;
            Classes.Escola.Email = txtEmail.Text;
            Classes.Escola.DataCricao = Convert.ToDateTime(dpDataCriacao.SelectedDate);
            Classes.Escola.TelefoneResp = txtTelefoneResposavel.Text;

            MessageBox.Show("Nome Fantasia: " + Classes.Escola.NomeFantasia + Environment.NewLine +
                            "Razão Social: " + Classes.Escola.RazaoSocial + Environment.NewLine +
                            "CNPJ: " + Classes.Escola.CNPJ + Environment.NewLine +
                            "Inscrição Estadual: " + Classes.Escola.InscEstadual + Environment.NewLine +
                            "Tipo = " + Classes.Escola.Tipo + Environment.NewLine +
                            "Responsável: " + Classes.Escola.Responsavel + Environment.NewLine +
                            "Rua: " + Classes.Escola.Rua + Environment.NewLine +
                            "Número: " + Classes.Escola.Numero + Environment.NewLine +
                            "Bairro: " + Classes.Escola.Bairro + Environment.NewLine +
                            "Complemento: " + Classes.Escola.Complemento + Environment.NewLine +
                            "CEP: " + Classes.Escola.CEP + Environment.NewLine +
                            "Cidade: " + Classes.Escola.Cidade + Environment.NewLine +
                            "Estado: " + Classes.Escola.Estado + Environment.NewLine +
                            "Telefone: " + Classes.Escola.Telefone + Environment.NewLine +
                            "Email: " + Classes.Escola.Email + Environment.NewLine +
                            "Data de Criação: " + Classes.Escola.DataCricao + Environment.NewLine +
                            "Telefone do Responsável: " + Classes.Escola.TelefoneResp
                            , "Cadastro Salvo", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void RdTipo_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton tipo = (sender as RadioButton);
            Classes.Escola.Tipo = tipo.Content.ToString();
        }
    }
}
