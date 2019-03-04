using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Campaign
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public int PRO_Property_FK { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Total { get; set; }
        public int PRO_CampaignType_FK { get; set; }
        public int PRO_Position_FK { get; set; }
        public string Note { get; set; }
        public int NoOfWeeks { get; set; }
        public int PRO_Company_FK { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Paid { get; set; }
        public int PRO_Package_FK { get; set; }
        public int PRO_Balance_FK { get; set; }
        public int UID { get; set; }
        public string TranslationScript { get; set; }
        public int PRO_Translation_FK { get; set; }
        public int PremiumViewCount { get; set; }
        public int PremiumClickCount { get; set; }
        public int PageViewCount { get; set; }
        public int ScanCount { get; set; }
    }
}
