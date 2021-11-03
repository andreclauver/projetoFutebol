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
    public partial class FrmCursos : Form
    {
        public FrmCursos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Curso objCurso = new Curso();
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            objCurso.CadastrarCurso();
            MessageBox.Show("Reistro cadastrado");
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string alterar = $@"update {tabela} set nomeCurso= '{txtNomeCurso}',
                   conteudo='{txtConteudo}', 
                   valorMensalidade='{txtValorMensalidade}'
                   cargaHoraria='{txtCargaHoraria}'where codigo='{txtCodigo}';";
            object.ExecutarComando(alterar);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string excluir = $"delete from {tabela} where codigo='{txtCodigo}'";
            object.ExecutarComando(excluir);
        }

        private void dgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
