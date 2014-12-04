using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventLogDataSource
{
    class Args
    {
        public string mode { get; set; }
        public int size { get; set; }
        public string locale { get; set; }
        public string parameters { get; set; }

        public Args()
        {
            mode = "preview";
            size = 0;
            locale = "en";
            parameters = "";
        }

        public static Args ParseCommandLineArgs()
        {
            Args args = new Args();

            string[] argsList = Environment.GetCommandLineArgs();

            using (IEnumerator<string> iter = ((IEnumerable<string>)argsList).GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    string arg = iter.Current;
                    if (arg == "-mode")
                    {
                        iter.MoveNext();
                        args.mode = iter.Current;
                    }
                    else if (arg == "-size")
                    {
                        iter.MoveNext();
                        args.size = Int32.Parse(iter.Current);
                    }
                    else if (arg == "-locale")
                    {
                        iter.MoveNext();
                        args.locale = iter.Current;
                    }
                    else if (arg == "-params")
                    {
                        iter.MoveNext();
                        args.parameters = iter.Current;
                    }
                }
            }
            return args;
        }
    };

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //WaitForDebugger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Args args = Args.ParseCommandLineArgs();
            EventLogWriter logWriter = CreateEventLogWriter(args);
            if (UiRequired(args))
            {
                Application.Run(new Form1(logWriter));
            }
            else
            {
                logWriter.Write();
            }
        }

        static bool UiRequired(Args args)
        {
            return args.mode == "refresh";
        }

        static EventLogWriter CreateEventLogWriter(Args args)
        {
            EventLogWriter logWriter = new EventLogWriter();
            if (args.size > 0)
            {
                logWriter.NumRows = args.size;
            }
            else if (args.parameters.Length > 0)
            {
                logWriter.ParseParameters(args.parameters);
            }
            return logWriter;
        }

        static void WaitForDebugger()
        {
            while (!System.Diagnostics.Debugger.IsAttached)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
