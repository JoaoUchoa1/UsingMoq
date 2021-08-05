using System;
using Connection;
namespace Moqs
{
    public class MoqConnection:IConnection
    {
        public bool ExecuteOnly(string sql)
        {
            return true;
        }
    }
}