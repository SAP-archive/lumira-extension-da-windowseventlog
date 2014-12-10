using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogDataSource
{
    public class EventLogWriter
    {
        public int NumRows { get; set; }
        public int NumRowsParameter { get; set; }

        public EventLogWriter()
        {
            NumRows = 50;
            NumRowsParameter = NumRows;
        }

        public void Write()
        {
            try
            {
                WriteDSInfoBlock();
                WriteDataBlock();
            }
            catch
            {
                // Error messages written to stderr are displayed by Lumira
                Console.Error.WriteLine("System event log could not be retrieved");
            }
        }

        public void ParseParameters(string parameters)
        {
            string[] paramsArr = parameters.Split(';');
            foreach(string param in paramsArr)
            {
                if (param.StartsWith("num_rows"))
                {
                    this.NumRows = Int32.Parse(param.Split('=')[1]);
                    this.NumRowsParameter = this.NumRows;
                    break;
                }
            }
        }

        protected void WriteDSInfoBlock()
        {
            Console.WriteLine("beginDSInfo");
            Console.WriteLine("csv_first_row_has_column_names;true;true;");
            Console.WriteLine("num_rows;" + NumRowsParameter + ";true;");
            Console.WriteLine("endDSInfo");
        }

        protected void WriteDataBlock()
        {
            Console.WriteLine("beginData");
            Console.WriteLine("Category,Source,Time Generated");

            EventLog eventLog = new EventLog("Application");
            IList<string> columns = new List<string>();

            for (int i = 0; i < eventLog.Entries.Count && i < NumRows; i++ )
            {
                EventLogEntry entry = eventLog.Entries[i];
                columns.Clear();
                columns.Add(EscapeSpecialChars(entry.EntryType));
                columns.Add(EscapeSpecialChars(entry.Source));
                columns.Add(EscapeSpecialChars(entry.TimeGenerated));
                Console.WriteLine(string.Join(",", columns));
            }

            Console.WriteLine("endData");
        }

        protected string EscapeSpecialChars(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            string field = obj.ToString();

            // Wrapping a field in quotation marks allows it to contain the CSV delimeter
            // Quotation mark characters have to be doubled up (" -> "")
            field = field.Replace("\"", "\"\"");
            return "\"" + field + "\"";
        }        
    }
}
