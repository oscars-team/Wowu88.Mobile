using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using Wowu88.Business.Cache;
using Wowu88.Business.Entity;

namespace Wowu88.Business.Repositoies
{
    public partial class PropertyRepository : BaseRsepository
    {
        private CacheByRedis redis = new CacheByRedis();
        private readonly string SQL_PropertyGet = @"select * FROM 
                          dbo.PRO_Property AS p INNER JOIN
                                      dbo.PRO_Campaign AS c ON p.Id = c.PRO_Property_FK AND c.Active = 1 AND c.CurrentStep = 159 INNER JOIN
                                      dbo.PRO_Package AS pck ON pck.Id = c.PRO_Package_FK INNER JOIN
                                      dbo.State AS st ON st.Id = p.State_FK AND st.Active = 1 INNER JOIN
                                      dbo.PRO_Photos AS ph ON ph.Property_FK = p.Id AND ph.Active = 1 AND ph.IsCover = 1 AND 
                                      ph.IsFloorPlan = 0 LEFT OUTER JOIN
                                      dbo.Suburbs AS sb ON sb.Id = p.Suburb_FK LEFT OUTER JOIN
                                      dbo.PRO_Area AS ar ON ar.Id = sb.Area_FK LEFT OUTER JOIN
                                      dbo.PRO_Translation AS tr ON p.Id = tr.PRO_Property_FK AND (tr.Active = 1 AND (tr.CurrentStep = 151 OR
                                      tr.CurrentStep = 163) OR
                                      pck.NoTranslationNeeded = 1) INNER JOIN
                                      dbo.PRO_Company AS cp ON cp.Id = p.Company_FK AND cp.CurrentStep = 194 AND 
                                      cp.Active = 1 LEFT OUTER JOIN
                                      dbo.PRO_Status AS s ON s.Id = p.PRO_Status_FK
where p.Active=1 and p.CurrentStep=143";

        private readonly string SQL_PropertyUpdate = "update pro_property values(@Id, @Title, @Order, @CurrentStep, @Dtm_Created)";

        private readonly string sql_propertyDelete = "delete * from pro_property where Id=@id";


        /// <summary>
        /// 获取全部房产
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Property> GetProperties()
        {
            var prop = Connection.Query(SQL_PropertyGet, new Type[10] {
                typeof(Property),
                typeof(Campaign),
                typeof(Package),
                typeof(State),
                typeof(Photos),
                typeof(Suburb),
                typeof(Area),
                typeof(Translation),
                typeof(Company),
                typeof(Status)
            }, map: (t) => {
                var p = t[0] as Property;
                var c = t[1] as Campaign;
                var pck = t[2] as Package;
                var st = t[3] as State;
                var ph = t[4] as Photos;
                var sb = t[5] as Suburb;
                var ar = t[6] as Area;
                var tr = t[7] as Translation;
                var cp = t[8] as Company;
                var s = t[9] as Status;
                p.campaign = c;
                p.package = pck;
                p.state = st;
                p.photos = ph;
                p.suburb = sb;
                p.area = ar;
                p.translation = tr;
                p.company = cp;
                p.status = s;
                return p;
            });
            redis.Write<IEnumerable<Property>>("property", prop, 0);
            return prop;
        }


        /// <summary>
        /// 更新房产
        /// </summary>
        /// <param name="property"></param>
        //public void UpdateProperty(Property property)
        //{

        //    Connection.Execute();
        //}

        //public void DeleteProperty(int id) {
        //    Connection.Execute(sql_propertyDelete,new { id=id });
        //}

        //public IEnumerable<Property> getPlatinums()
        //{
        //    var property = redis.Read<IEnumerable<Property>>("property", 0);
        //    List<Property> list = new List<Property> { };
        //    foreach (var prop in property) {
        //        if (prop.package.IsPlatinum == true && prop.campaign.ExpiryDate > DateTime.Now) {
        //            list.Add(prop);
        //        }
        //    }
        //    return list;
        //}

        //public IEnumerable<Property> getNews() {
        //    var property = redis.Read<IEnumerable<Property>>("property", 0);
        //    List<Property> list = new List<Property> { };
        //    DateTime now = DateTime.Now;
        //    foreach (var news in list) {
        //        if (news.Dtm_Created>=now.AddDays(-30)) {
        //            list.Add(news);
        //        }
        //    }
        //    return list;
        //}

    }
}
