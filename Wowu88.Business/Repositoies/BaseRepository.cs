using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Wowu88.Business.Repositoies
{
    public class BaseRsepository : Repository
    {
        public BaseRsepository() : base(new AppConfiguration().ConnectionString)
        {

        }
    }
}
