using GoonListados.Models;
using System.Collections.Generic;

namespace GoonListados.Helpers
{
    public class DataHelper
    {

        public static List<DataItem> p_GetData(string modulo)
        {
            List<DataItem> _list = new List<DataItem>();

            for (int x = 1; x <= 50; x++)
            {

                DataItem _i = new DataItem
                {
                    datos1 = modulo + " " + x.ToString() + " Col 1",
                    datos2 = modulo + " " + x.ToString() + " Col 2",
                    datos3 = modulo + " " + x.ToString() + " Col 3",
                    datos4 = modulo + " " + x.ToString() + " Col 4",
                    datos5 = modulo + " " + x.ToString() + " Col 5",
                    datos6 = modulo + " " + x.ToString() + " Col 6"
                };

                _list.Add(_i);

            }

            return _list;
        }

    }
}