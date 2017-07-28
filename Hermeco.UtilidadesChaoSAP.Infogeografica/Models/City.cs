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

        internal static City GetCity(string departmentName, string cityName)
        {
            cityName = Utilities.RemoveSpecialCharacters(cityName);
            cityName = Utilities.RemoveDiacritics(cityName);
            departmentName = Utilities.RemoveSpecialCharacters(departmentName);
            departmentName = Utilities.RemoveDiacritics(departmentName);
            City city = new City();
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {                  
                    var department = Department.GetDepartment(departmentName);

                    var Query2 = session.QueryOver<City>()
                    .Where(x => x.Name == cityName.ToUpper().Trim() && x.Department == department)                    
                    .List();                   

                    city = Query2.First();
                    
                }
            }
            catch (Exception ex)
            {

            }
            return city;

        }
    }
}