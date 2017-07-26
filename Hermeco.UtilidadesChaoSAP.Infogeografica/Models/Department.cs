using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    public class Department
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual Country Country { get; set; }
    }
}
