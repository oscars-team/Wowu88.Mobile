using System;
using System.Collections.Generic;
using System.Text;

namespace Wowu88.Business.Entity
{
    public class Translation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public int PRO_Property_FK { get; set; }
        public int Region_FK { get; set; }
        public int PRO_Translator_FK { get; set; }
        public string Description { get; set; }
        public string Headline { get; set; }
        public string EnglishHeadline { get; set; }
        public string EnglishDescription { get; set; }
        public decimal Rate { get; set; }
        public int UID { get; set; }
        public int WordCount { get; set; }
        public string Note { get; set; }
        public string EnglishPaperDescription { get; set; }
        public string PaperDescription { get; set; }
    }
}
