using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    [Serializable]
    public class Country
    {
        public virtual int ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name {get; set;}

        
        public static Country GetCountry(string Name)
        {
            Country country = new Country();
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    var countryQuery = session.QueryOver<Country>()
                    .Where(x => x.Name == Utilities.RemoveSpecialCharacters(Name))
                    .List();

                    country = countryQuery.First();
                }
            }
            catch
            {

            }
            return country;
        }
    
    }
}
