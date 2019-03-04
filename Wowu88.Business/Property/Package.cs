using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Package
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public int WeeksOnWebsite { get; set; }
        public int WeeksOnPaper { get; set; }
        public dynamic Price { get; set; }
        public int PRO_Template_FK { get; set; }
        public int PRO_Company_FK { get; set; }
        public bool Repeat { get; set; }
        public int UID { get; set; }
        public bool NoTranslationNeeded { get; set; }
        public int PRO_Classification_FK { get; set; }
        public bool OnceOffPrice { get; set; }
        public bool AgencyOnly { get; set; }
        public int State_FK { get; set; }
        public string Description { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsPlatinum { get; set; }
        public bool IsHot { get; set; }
    }
}
