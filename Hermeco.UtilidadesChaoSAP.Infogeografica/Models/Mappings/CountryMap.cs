using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models.Mappings
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            Table("country");
            Id(x => x.ID);
            Map(x => x.Code).Column("country_code"); 
            Map(x => x.Name).Column("country_name"); 
        }
    }
}