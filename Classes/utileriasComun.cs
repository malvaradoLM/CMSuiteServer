using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPSuiteServer.Classes
{
   public class utileriasComun
    {
        public class FillCombos
        {
            public int ID { get; set; }
            public string Nombre { get; set; }

            public List<FillCombos> FillListCombo(DataTable dt, string id, string nombre)
            {
                List<FillCombos> combo = new List<FillCombos>();
                IEnumerable<DataRow> query = from dts in dt.AsEnumerable() select dts;


                foreach (DataRow dr in query)
                {
                    combo.Add(new FillCombos() { ID = dr.Field<int>(id), Nombre = dr.Field<string>(nombre) });
                }
                return combo;
            }
        }
    }
}
