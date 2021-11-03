using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigoCurso;
        public string nomeCurso, conteudoProgramatico, cargaHoraria;
        public double valorMensalidade;

        string tabela = "tbl_curso";

        Conexao obj = new Conexao();

        public void CadastrarCurso()
        {
            string inserir = $"insert into {tabela} values(null, '{nomeCurso}', '{conteudoProgramatico}', '{valorMensalidade}', '{cargaHoraria}')";
            conexao.ExecutarComando(inserir);
        }

        public void AlterarCurso()
        {
            string alterar = $"UPDATE {tabela} SET nomeCurso = {nomeCurso}', conteudo = '{conteudoProgramatico}', valorMensalidade = ', " +
                $" cargaHoraria = '{cargaHoraria}' WHERE codigo = '{codigoCurso}' ";
            conexao.ExecutarComando(alterar);
        }

        public void ExcluirCurso()
        {
            string deletar = $"delete from {tabela} where codigo = {codigoCurso}";
            conexao.ExecuatrComando(deletar);
        }

        public DataTable ListarCursos()     //Requer: using System.Data;
        {
            return null;
        }
    }
}
