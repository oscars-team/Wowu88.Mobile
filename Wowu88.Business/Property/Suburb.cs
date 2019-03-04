using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Suburb
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public int State_FK { get; set; }
        public int Postcode { get; set; }
        public int UID { get; set; }
        public int Area_FK { get; set; }
    }
}
