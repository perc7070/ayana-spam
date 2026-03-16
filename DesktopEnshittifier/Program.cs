using System;
using System.IO;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Drawing;

class Enshittify
{
    static void Main()
    {

        string ayanapngplace = @"C:\deletethislaterbro";
        if (!Directory.Exists(ayanapngplace))
        {
            Directory.CreateDirectory(ayanapngplace);
        }
        string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //I dont even remember why tf this is here where do i even use this

        //this does a load of bullshit makes a file cos fuck it why not amirite :|
        Bitmap ayanaBitmap = DesktopEnshittifier.Resource1.ayana;
        string pathToAyana = Path.Combine(ayanapngplace, "ayaner.png");
        ayanaBitmap.Save(pathToAyana);
        // this is all straight shit idgaf tho :P

        Console.WriteLine("Type 'start' to Start"); // this bullshit doesnt even do anything i hateit

        if (Console.ReadLine() == "start")
        {
            try
            {
                using (Process openAyaners = new Process())
                {
                    openAyaners.StartInfo.FileName = pathToAyana;

                    while (true)
                    {
                        openAyaners.Start();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("sorry" + e.Message);
                using (Process openAyaners = new Process())
                {
                    openAyaners.StartInfo.FileName = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    //this is dumb i am dumb
                    openAyaners.StartInfo.Arguments = pathToAyana;

                    while (true)
                    {
                        openAyaners.Start();
                    }
                }
            }
        }
    }
}