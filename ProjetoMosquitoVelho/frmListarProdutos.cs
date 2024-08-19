using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoMosquitoVelho
{
    public partial class frmListarProdutos : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmListarProdutos()
        {

            InitializeComponent();
            //Executando o médotodo para carregar a combobox
            carregaCombo();
        }
                                                                                                                                                                                                                                                                                    
        public void carregaCombo()
        {
            produtos[0] = "Banana";
            produtos[1] = "Morango";
            produtos[2] = "Melancia";
            produtos[3] = "Kiwi";
            produtos[4] = "Lichia";
            produtos[5] = "Melão";
            produtos[6] = "Maçã";
            produtos[7] = "Abacaxi";
            produtos[8] = "Laranja";
            produtos[9] = "Pêssego";

            for (int i = 0; i < produtos.Length; i++)
            {
                cboProdutos.Items.Add(produtos[i]);

            }
        }


        private void frmListarProdutos_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //criando um vetor
        string[] produtos = new string[10];


        private void btnCarregar_Click(object sender, EventArgs e)
        {
            

            //Inserindo valores no vetor
            produtos[0] = "Banana";
            produtos[1] = "Morango";
            produtos[2] = "Melancia";
            produtos[3] = "Kiwi";
            produtos[4] = "Lichia";
            produtos[5] = "Melão";
            produtos[6] = "Maçã";
            produtos[7] = "Abacaxi";
            produtos[8] = "Laranja";
            produtos[9] = "Pêssego";



            //imprimindo os vetores
            //MessageBox.Show("Produto "+ produtos[0]);
            //MessageBox.Show("Produto "+ produtos[5]);

            //Limpando os itens da Lista
            ltbListadeProdutos.Items.Clear();

            //Percorrendo o vetor criado
            for (int i = 0; i < produtos.Length; i++)
            {
                ltbListadeProdutos.Items.Add(produtos[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("O que está acontecendo.");
            produtos[0] = "Banana";
            produtos[1] = "Morango";
            produtos[2] = "Melancia";
            produtos[3] = "Kiwi";
            produtos[4] = "Lichia";
            produtos[5] = "Melão";
            produtos[6] = "Maçã";
            produtos[7] = "Abacaxi";
            produtos[8] = "Laranja";
            produtos[9] = "Pêssego";

            cboListarItens.Items.Clear();

            for (int i = 0; i < produtos.Length; i++)
            {
                cboListarItens.Items.Add(produtos[i]);

            }
        }

        private void btnTestarPessoa_Click(object sender, EventArgs e)
        {
            //instanciando o objeto
            Pessoa p = new Pessoa();
            p.Nome = "Senac";
            lblTestarPessoa.Text = p.Nome;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Bilhete bilhete = new Bilhete();

            bilhete.Documento = mtbDocumento.Text;
            bilhete.NumeroCartao = mtbNumerodoCartao.Text;

            mtbDocumento.Text = bilhete.Documento;
            mtbNumerodoCartao.Text = bilhete.NumeroCartao;

            bilhete.Documento = "Senac";
            bilhete.NumeroCartao = "ABC123DEF";

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTestarLogin_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin(txtTestaLogin.Text);
            abrir.Show();
        }
    }
}
