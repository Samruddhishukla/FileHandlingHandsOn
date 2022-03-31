using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlinDemo
{
    class FileHandling
    {
        public void WriteFile()
        {
            FileStream fileStream = new FileStream("F:\\Capgemini\\test.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Welcome to C# Programming");
            writer.Close();
            fileStream.Close();
        }
        public void ReadFile()
        {
            FileStream fileStream = new FileStream("F:\\Capgemini\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("StudentId\tStudentName\tMarks");
            while (reader.Peek() > 0)
            {
                var studid = reader.ReadLine();
                String[] studIDStr = studid.Split(':');
                String id = studIDStr[1];

                var studname = reader.ReadLine();
                String[] studNameStr = studname.Split(':');
                String name = studNameStr[1];

                var markstr = reader.ReadLine();
                String[] studMarkstr = markstr.Split(':');
                int mark = Convert.ToInt32(studMarkstr[1]);
                if (mark > 49)
                {
                    Console.WriteLine(id+"\t\t"+name+"\t\t"+mark);
                }
                reader.ReadLine();
            }
        }
    }
}
