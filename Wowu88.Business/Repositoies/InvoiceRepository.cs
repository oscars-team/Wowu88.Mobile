using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Repositoies
{
    public class InvoiceRepository : BaseRsepository
    {
        public void Get()
        {
            var p = Connection.Query("select * from Pro_Property");
        }
    }
}
