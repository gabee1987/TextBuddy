using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TextBuddy
{
    class IOManager
    {
        public static string OpenTextFile(string openPath)
        {
            String result = "";
            try
            {
                using (StreamReader reader = new StreamReader(openPath))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ioe.Message);
            }
            return result;
        }

        public static List<String> OpenTextFileByLines(string openPath)
        {
            List<String> result = new List<String>();
            try
            {
                using (StreamReader reader = new StreamReader(openPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        result.Add(line); // Add to list.
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ioe.Message);
            }
            return result;
        }

        public static void WriteToFile(string writePath, string dataToWrite)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(writePath))
                {
                    writer.Write(dataToWrite);
                }
            }

            catch (IOException ioe)
            {
                Console.WriteLine("The file could not be write:");
                Console.WriteLine(ioe.Message);
            }
        }

        public static void WriteToFileByLines(string writePath, List<String> dataToWrite)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(writePath))
                {
                    foreach (String line in dataToWrite)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("The file could not be write:");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}