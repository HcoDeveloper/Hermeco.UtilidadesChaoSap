using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models.Mappings
{
    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Table("city");
            Id(d => d.ID);
            Map(d => d.Code).Column("city_code");
            Map(d => d.Name).Column("city_name");
            References(d => d.Department).Not.LazyLoad(); ;
        }
    }
}