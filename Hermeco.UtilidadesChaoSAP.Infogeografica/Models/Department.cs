using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica.Models
{
    [Serializable]
    public class Department
    {
        public virtual string ID { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        
        public virtual Country Country { get; set; }

        internal static Department GetDepartment(string name)
        {
            name = Utilities.RemoveSpecialCharacters(name);
            name = Utilities.RemoveDiacritics(name);
            Department department = new Department();
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    var countryQuery = session.QueryOver<Department>()
                    .Where(x => x.Name == name.ToUpper().Trim())
                    .List();

                    department = countryQuery.First();
                }
            }
            catch(Exception ex)
            {

            }
            return department;
        
        }
    }
}
