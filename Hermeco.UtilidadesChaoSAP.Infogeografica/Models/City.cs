using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    public class City
    {
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }        
        Department Department {get; set;}
    }
}