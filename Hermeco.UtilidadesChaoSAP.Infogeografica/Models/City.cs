using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    public class City
    {
        public virtual int ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual Department Department { get; set; }
    }
}