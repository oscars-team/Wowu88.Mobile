using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public int DAM_Asset { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string RLA { get; set; }
        public string LogoUrl { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string GeneralPricing { get; set; }
        public string AccountName { get; set; }
        public string ABN { get; set; }
        public string Fax { get; set; }
        public string BillingDetails { get; set; }
        public string BillingTelephone { get; set; }
        public string BillingFax { get; set; }
        public string BillingEmail { get; set; }
        public int UID { get; set; }
        public string BackgroundColor { get; set; }
        public string OfficeUrl { get; set; }
        public string CustomPDF { get; set; }
        public bool DirectDebit { get; set; }
        public string InvoiceCode { get; set; }
        public string CCEmails { get; set; }
        public int State_FK { get; set; }

    }
}
