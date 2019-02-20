using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Property
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public Campaign Campaign { get; set; }
    }
}
