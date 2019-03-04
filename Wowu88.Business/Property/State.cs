using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class State
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public string AbbreviationCode { get; set; }
        public int IsCheckedOut { get; set; }
        public int Country_FK { get; set; }
        public string Chinese { get; set; }
        public int UID { get; set; }
    }
}
