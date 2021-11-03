using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmProfessores : Form
    {
        public FrmProfessores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professores objProfessor = new Professores();
            objProfessor.codigoProfessor = int.Parse(txtCodigo.Text);
            objProfessor.nomeProfessor = txtNome.Text;
            objProfessor.valorAula = double.Parse(txtValor.Text);
            objProfessor.telProfessor = int.Parse(txtTelefone.Text);
            objProfessor.CadastrarProfessores();
            MessageBox.Show("Reistro cadastrado");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string alterar = $@"update {tabela} set nomeCurso= '{txtCodigo}',
                   conteudo='{txtNome}', 
                   valorMensalidade='{txtValor}'
                   cargaHoraria='{txtTelefone}'where codigo='{txtCodigo}';";
            object.ExecutarComando(alterar);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string excluir = $"delete from {tabela} where codigo='{txtCodigo}'";
            object.ExecutarComando(excluir);
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            string sql = $"select from {tabela} order by codigo";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
