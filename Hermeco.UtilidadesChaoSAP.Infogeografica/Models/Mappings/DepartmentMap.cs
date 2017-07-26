using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models.Mappings
{
    public class DepartmentMap: ClassMap<Department>
    {
        public DepartmentMap()
        {
            Table("department");
            Id(d => d.ID);
            Map(d => d.Code).Column("department_code");
            Map(d => d.Name).Column("department_name");
            References(d => d.Country);
        }
    }
}