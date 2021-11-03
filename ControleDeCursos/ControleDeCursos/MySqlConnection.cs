using System;

namespace ControleDeCursos
{
    internal class MySqlConnection
    {
        private string conn;

        public MySqlConnection(string conn)
        {
            this.conn = conn;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}