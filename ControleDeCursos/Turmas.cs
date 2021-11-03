using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Turmas
{
    public string professor, curso, dataInicio, dataTermino;;
    public int codigoTurma, horaInicio, horaTermino;

    string tabela = "tbl_turmas";

    public void CadastrarTurmas()
    {
        string inserir = $"insert into {tabela} values(null, '{codigoTurma}', '{curso}', '{dataInicio}', '{dataTermino}', '{horaInicio}','{horaTermino}', '{dataInicio}','{dataTermino}',)
        conexao.ExecutarComando(inserir);
    }

    public void Alterarturmas()
    {
        string alterar = $"UPDATE {tabela} SET codigo = {codigoTurma}', nomeCurso = '{curso}',  WHERE nomeProfessor = '{professor}' ";
        conexao.ExecutarComando(alterar);
    }

    public void ExcluirTurmas()
    {
        string deletar = $"delete from {tabela} where codigo = {codigoTurma}";
        conexao.ExecuatrComando(deletar);
    }

    public DataTable ListarTurmas()     //Requer: using System.Data;
    {
        return null;
    }
}

