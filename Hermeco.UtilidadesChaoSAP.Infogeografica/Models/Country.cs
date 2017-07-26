using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    public class Country
    {
        public virtual int ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name {get; set;}
    }
}
