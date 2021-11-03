using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_POO
{
    class Produto
    {
        public string nome, descricao, data_de_fabricacao, data_de_validade;
        public int quantidade, valor_unitario, codigo;
        public string tabela = "tbl_produto";
        conexaopoo objconexao = new conexaopoo();

        public void CadastrarProduto()
        {
            string cadastrar = $@"insert into {tabela} values
                                (null,'{nome}','{descricao}',
                                '{quantidade}','{valor_unitario}',
                                '{data_de_fabricacao}','{data_de_validade}' ); ";

            objconexao.ExecutarComando(cadastrar);
        }
        public DataTable ListarProduto()
        {
            string listar = $"select * from {tabela} order by codigo;";
            return objconexao.ExecutarConsulta(listar);
        }
    }
}
