using System;

namespace Connection
{
    public interface IConnection
    {

        bool ExecuteOnly(String sql);

    }
}