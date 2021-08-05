using System;

namespace Connection
{
    public class MyConnection:IConnection
    {
        public bool ExecuteOnly(string sql) => false;
    }
}