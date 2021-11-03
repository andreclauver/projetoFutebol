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
    public partial class FrmTurmas : Form
    {
        public FrmTurmas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turmas objTurma = new Turmas();
            objTurma.codigoTurma = int.Parse(txt_Codigo.Text);
            objTurma.dataInicio = dateTime_Inicio;
            objTurma.dataTermino = dateTime_Termino;
            objTurma.horaInicio = int.Parse(txt_HoraInicio.Text);
            objTurma.horaTermino = int.Parse(txt_HoraTerimino.Text);
            comboBox_Professor.DataSource = listarProfessor();
            comboBox_Professor.ValueMember = "codigo";
            comboBox_Professor.DisplayMember = "nome";
            int codigoProfessor = int.Parse(comboBox_Professor.SelectedValue);
            objTurma.CadastrarCurso();
            MessageBox.Show("Reistro cadastrado");
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            string alterar = $@"update {tabela} set codigoTurmas= '{txt_Codigo}',
                   conteudo='{comboBox_Professor}', 
                   Curso='{comboBox_Curso}'
                   cargaHoraria='{txt_HoraInicio}'where codigo='{txt_Codigo}';";
            object.ExecutarComando(alterar);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            string deletar = $"delete from {tabela} where codigo = {txt_Codigo}";
            conexao.ExecuatrComando(deletar);
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            return null;
        }
    }
}
