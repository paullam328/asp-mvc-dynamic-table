using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTableExplorer.Models
{
    public class DataTableModel
    {
        public DataTableModel(JObject m_data, JArray m_arrOfData)

        {
            data = m_data;
            arrOfData = m_arrOfData;
        }
        public JObject data { get; set; }
        public JArray arrOfData { get; set; }
    }
}
