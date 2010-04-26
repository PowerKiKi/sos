using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace SOS
{
   static class Program
   {
      public static readonly string applicationDataPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "sos");
      public static readonly string dumpFile = System.IO.Path.Combine(applicationDataPath, "sos-res.htm");

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         Console.WriteLine(string.Format("dumpFile={0}", Program.dumpFile));
         System.IO.Directory.CreateDirectory(Program.applicationDataPath);
         if (args.Length >= 4)
         {
            Orange site = new Orange();
            site.login(args[0], args[1]);
            Console.WriteLine("log in ...");
            if (site.IsLogged)
            {
               Console.WriteLine("sending ...");

               string message = "";
               for (int i = 3; i < args.Length; i++)
                  message += " " + args[i];

               if (site.send(args[2], message, ""))
                  Console.WriteLine("sent !");
               else
               {
                  Console.Write("Failed !");
#if DEBUG
                  Console.WriteLine(site);
#endif
               }
            }
            else
            {
               Console.Write("Log in failed !");
#if DEBUG
               Console.WriteLine(site);
#endif
            }
            System.IO.StreamWriter writer = new System.IO.StreamWriter(Program.dumpFile);
            writer.WriteLine(site.LastResult);
            writer.Close();
         }
         else if (args.Length == 0)
         {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         }
         else
         {
            Console.WriteLine("SOS - Orange.ch SMS Sender\n USAGE:\n " + Application.ExecutablePath + " login password number[;number]+ message");
         }
      }
   }
}
