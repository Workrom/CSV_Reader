using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Reader
{
    internal class CsvHandler
    {
        public DataTable ReadCsv(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (var reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine().Split(',');

                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');
                    dataTable.Rows.Add(values);
                }
            }
            return dataTable;
        }

        public void WriteCsv(string filePath, DataTable dataTable)
        {
            using (var writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    writer.WriteLine($"{row["Name"]},{row["Age"]},{row["Programmer"]}");
                }
            }
        }
    }
}
