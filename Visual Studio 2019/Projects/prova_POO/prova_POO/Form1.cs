using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_POO
{
    public partial class Form1 : Form
    {
        Produto objProduto = new Produto();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            objProduto.nome = nome_txt.Text;
            objProduto.descricao = desc_txt.Text;
            objProduto.quantidade = int.Parse(qnt_txt.Text);
            objProduto.valor_unitario = int.Parse(valun_txt.Text);
            objProduto.data_de_fabricacao = dataFab_txt.Text;
            objProduto.data_de_validade = dataVal_txt.Text;

            objProduto.CadastrarProduto();
            MessageBox.Show("produto Cadastrado");
            nome_txt.Clear();
            desc_txt.Clear();
            qnt_txt.Clear();
            valun_txt.Clear();
            dataFab_txt.Clear();
            dataVal_txt.Clear();
            dtgProduto.DataSource = objProduto.ListarProduto();


        }

        private void btn_listar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgProduto.DataSource = objProduto.ListarProduto();
        }

    }
}
