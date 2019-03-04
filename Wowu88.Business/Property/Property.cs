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
        public bool Active { get; set; }
        public int CurrentStep { get; set; }
        public DateTime Dtm_Created { get; set; }
        public DateTime Dtm_Updated { get; set; }
        public bool IsCheckedOut { get; set; }
        public  int NoOfBedroom { get; set; }
        public int NoOfBathroom { get; set; }
        public int NoOfCarspace { get; set; }
        public string Description { get; set; }
        public int State_FK { get; set; }
        public int Company_FK { get; set; }
        public int  PRO_Type_FK { get; set; }
        public int Suburb_FK { get; set; }
        public int  MinPrice { get; set; }
        public int  MaxPrice { get; set; }
        public string Headline { get; set; }
        public string InspectionTime { get; set; }
        public int PRO_Status_FK { get; set; }
        public bool NewProperty { get; set; }
        public bool IsAuction { get; set; }
        public DateTime AuctionTime { get; set; }
        public DateTime InspectionStartTime1 { get; set; }
        public DateTime InspectionFinishTime1 { get; set; }
        public DateTime InspectionStartTime2 { get; set; }
        public DateTime InspectionFinishTime2 { get; set; }
        public DateTime InspectionStartTime3 { get; set; }
        public DateTime InspectionFinishTime3 { get; set; }
        public int UID { get; set; }
        public string REID { get; set; }
        public bool PhotosImported { get; set; }
        public int PageViewCounts { get; set; }
        public int Area_FK { get; set; }
        public int PRO_TenureType_FK { get; set; }
        public int PRO_Classification_FK { get; set; }
        public int LandSize { get; set; }
        public int  FloorArea { get; set; }
        public string Zoning { get; set; }
        public string Building { get; set; }
        public string Municipality { get; set; }
        public string ParkingComments { get; set; }
        public string Note { get; set; }
        public int Likes { get; set; }
        public bool DisplayPrice { get; set; }
        public string AltDisplayPrice { get; set; }
        public string UniqueID { get; set; }
        public int PremierProperty { get; set; }
        public decimal BondAmount { get; set; }
        public string DateAvailable { get; set; }
        public string FeedStatus { get; set; }
        public Campaign campaign { get; set; }
        public Photos photos { get; set; }
        public Company company { get; set; }
        public Package package { get; set; }
        public Status status { get; set; }
        public Translation translation { get; set; }
        public State state { get; set; }
        public Suburb suburb { get; set; }
        public Area area { get; set; }
        public Classification classification { get; set; }
    }
}
