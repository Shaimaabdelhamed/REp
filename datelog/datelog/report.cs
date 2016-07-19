using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for report
/// </summary>
public class report
{
    public report()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool Writetxt(string logMessage, TextWriter w)
    {
        if (logMessage != null && w != null)
        {
            w.Write("\r\nThe Date is : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
            return true;
        }
        else { return false; }
    }

    public void Readtxt(StreamReader r)
    {
        string line;
        while ((line = r.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}