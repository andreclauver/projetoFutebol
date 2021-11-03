using System;
using System.Data;

namespace ControleDeCursos
{
    internal class MySqlDataAdapter
    {
        private string sql;
        private MySqlConnection conexao;

        public MySqlDataAdapter(string sql, MySqlConnection conexao)
        {
            this.sql = sql;
            this.conexao = conexao;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}