using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Professores
{
    public int codigoProfessor, telProfessor;
    public string nomeProfessor;
    public double valorAula;

    string tabela = "tbl_professor";

    public void CadastrarProfessores()
    {
        string inserir = $"insert into {tabela} values(null, '{codigoProfessores}', '{nomeProfessores}', '{valorAula}', '{telProfessores}')";
        conexao.ExecutarComando(inserir);
    }

    public void AlterarProfessores()
    {
        string alterar = $"UPDATE {tabela} SET nomeCurso = {codigoProfessores}', conteudo = '{nomeProfessores}', valorMensalidade = ', " +
            $" cargaHoraria = '{valorAula}' WHERE codigo = '{telProfessores}' ";
        conexao.ExecutarComando(alterar);
    }

    public void ExcluirProfessores()
    {
        string deletar = $"delete from {tabela} where codigo = {codigoProfessores}";
        conexao.ExecuatrComando(deletar);
    }

    public DataTable ListarProfessores()     //Requer: using System.Data;
    {
        return null;
    }
}


