using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    class Department
    {
        string ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        Country Country { get; set; }
    }
}
