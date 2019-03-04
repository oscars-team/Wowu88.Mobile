using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Photos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public int  DAM_Asset_FK { get; set; }
        public int Property_FK { get; set; }
        public string Url { get; set; }
        public bool IsFloorPlan { get; set; }
        public bool IsCover { get; set; }
        public int UID { get; set; }
    }
}
