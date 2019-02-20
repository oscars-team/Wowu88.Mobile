using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using Wowu88.Business.Entity;

namespace Wowu88.Business.Repositoies
{
    public partial class PropertyRepository : BaseRsepository
    {
        private readonly string SQL_PropertyGet = @"
select * from pro_property p
inner join pro_campaign c on p.id = c.pro_property_fk";
        private readonly string SQL_PropertyUpdate = "update pro_property values(@Id, @Title, @Order, @CurrentStep, @Dtm_Created)";




        /// <summary>
        /// 获取全部房产
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Property> GetProperties()
        {

            return Connection.Query<Property, Campaign, Property>(SQL_PropertyGet, (p, c) => { p.Campaign = c; return p; });
        }

        /// <summary>
        /// 更新房产
        /// </summary>
        /// <param name="property"></param>
        public void UpdateProperty(Property property)
        {
            //...
            //...
            Connection.Execute(SQL_PropertyUpdate, property);
        }



    }
}
