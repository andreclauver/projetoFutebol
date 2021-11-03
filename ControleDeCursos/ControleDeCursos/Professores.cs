using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Professores
    {
        public int codigoProfessor, telProfessor;
        public string nomeProfessor;
        public double valorAula;

        string tabela = "tbl_professor";

        public void CadastrarProfessores()
        {
            string inserir = $"insert into {tabela} values(null, '{codigoProfessor}', '{nomeProfessor}', '{valorAula}', '{telProfessor}')";
            conexao.ExecutarComando(inserir);
        }

        public void AlterarProfessores()
        {
            string alterar = $"UPDATE {tabela} SET nomeCurso = {codigoProfessor}', conteudo = '{nomeProfessor}', valorMensalidade = ', " +
                $" cargaHoraria = '{valorAula}' WHERE codigo = '{telProfessor}' ";
            conexao.ExecutarComando(alterar);
        }

        public void ExcluirProfessores()
        {
            string deletar = $"delete from {tabela} where codigo = {codigoProfessor}";
            conexao.ExecuatrComando(deletar);
        }

        public DataTable ListarProfessores()     //Requer: using System.Data;
        {
            return null;
        }
    }
}
