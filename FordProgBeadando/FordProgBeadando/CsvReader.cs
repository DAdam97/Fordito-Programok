using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FordProgBeadando
{
    class CsvReader
    {
        public static DataTable GetRules(string filePath)
        {
            DataTable table = new DataTable();

            var rulescsv = filePath;

            string[] csvLines = File.ReadAllLines(rulescsv);

            if (csvLines.Length > 0)
            {
                string[] header = csvLines[0].Split(',');

                foreach (var TerminalSymbol in header)
                {
                    table.Columns.Add(TerminalSymbol);
                }

                for (int i = 1; i < csvLines.Length; i++)
                {
                    string[] ruleRows = csvLines[i].Split(',');
                    DataRow row = table.NewRow();
                    int index = 0;

                    foreach (var rowCell in header)
                    {
                        row[rowCell] = ruleRows[index++];
                    }
                    table.Rows.Add(row);
                }
            }

            return table;
        }



    }
}
