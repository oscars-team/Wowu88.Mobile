using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Wowu88.Business.Repositoies
{
    public abstract class Repository
    {
        /// <summary>
        /// 数据库连接
        /// </summary>
        public IDbConnection Connection { get; private set; }

        public Repository(IDbConnection connection)
        {
            Connection = connection;
        }

        public Repository(string connectionString) : this(new SqlConnection(connectionString))
        {

        }
    }
}
