using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TAMU_CSV_Merge
{
    class Program
    {
        public static string imagePathReport4full = @"\ResultReport4Item.csv";
        public static string imagePathReport3full = @"\ResultReport3Item.csv";
        public static string finalImagePathReport4full = AssemblyDirectory + imagePathReport4full;
        public static string finalImagePathReport3full = AssemblyDirectory + imagePathReport3full;

        //Path for Report4
        //Project1
        public static string Project1PathReport4 = @"\TAMUExport\Project1";

        //Project2
        public static string Project2PathReport4 = @"\TAMUExport\Project2";

        //Project3
        public static string Project3PathReport4 = @"\TAMUExport\Project3";

        //Project4
        public static string Project4PathReport4 = @"\TAMUExport\Project4";

        //Project5
        public static string Project5PathReport4 = @"\TAMUExport\Project5";

        //Project6
        public static string Project6PathReport4 = @"\TAMUExport\Project6";

        //Project7
        public static string Project7PathReport4 = @"\TAMUExport\Project7";

        //Project8
        public static string Project8PathReport4 = @"\TAMUExport\Project8";

        //Project9   
        public static string Project9PathReport4 = @"\TAMUExport\Project9";

        //Project10
        public static string Project10PathReport4 = @"\TAMUExport\Project10";

        //Project11
        public static string Project11PathReport4 = @"\TAMUExport\Project11";

        //Project12
        public static string Project12PathReport4 = @"\TAMUExport\Project12";

        //Project13
        public static string Project13PathReport4 = @"\TAMUExport\Project13";

        //Project14
        public static string Project14PathReport4 = @"\TAMUExport\Project14";

        //Project15
        public static string Project15PathReport4 = @"\TAMUExport\Project15";

        //Project16
        public static string Project16PathReport4 = @"\TAMUExport\Project16";

        //Project17
        public static string Project17PathReport4 = @"\TAMUExport\Project17";

        //Project18
        public static string Project18PathReport4 = @"\TAMUExport\Project18";

        //Project19
        public static string Project19PathReport4 = @"\TAMUExport\Project19";

        //Project20
        public static string Project20PathReport4 = @"\TAMUExport\Project20";

        //Path for Report3
        //Project1
        public static string Project1PathReport3 = @"\TAMUExport\Project1";

        //Project2
        public static string Project2PathReport3 = @"\TAMUExport\Project2";

        //Project3
        public static string Project3PathReport3 = @"\TAMUExport\Project3";

        //Project4
        public static string Project4PathReport3 = @"\TAMUExport\Project4";

        //Project5
        public static string Project5PathReport3 = @"\TAMUExport\Project5";

        //Project6
        public static string Project6PathReport3 = @"\TAMUExport\Project6";

        //Project7
        public static string Project7PathReport3 = @"\TAMUExport\Project7";

        //Project8
        public static string Project8PathReport3 = @"\TAMUExport\Project8";

        //Project9   
        public static string Project9PathReport3 = @"\TAMUExport\Project9";

        //Project10
        public static string Project10PathReport3 = @"\TAMUExport\Project10";

        //Project11
        public static string Project11PathReport3 = @"\TAMUExport\Project11";

        //Project12
        public static string Project12PathReport3 = @"\TAMUExport\Project12";

        //Project13
        public static string Project13PathReport3 = @"\TAMUExport\Project13";

        //Project14
        public static string Project14PathReport3 = @"\TAMUExport\Project14";

        //Project15
        public static string Project15PathReport3 = @"\TAMUExport\Project15";

        //Project16
        public static string Project16PathReport3 = @"\TAMUExport\Project16";

        //Project17
        public static string Project17PathReport3 = @"\TAMUExport\Project17";

        //Project18
        public static string Project18PathReport3 = @"\TAMUExport\Project18";

        //Project19
        public static string Project19PathReport3 = @"\TAMUExport\Project19";

        //Project20
        public static string Project20PathReport3 = @"\TAMUExport\Project20";

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return System.IO.Path.GetDirectoryName(path);
            }
        }

        private static void Report4Merge()
        {
            string[] sourceFolder = new string[] {
            AssemblyDirectory + Project1PathReport4, AssemblyDirectory + Project2PathReport4, AssemblyDirectory + Project3PathReport4, AssemblyDirectory + Project4PathReport4, AssemblyDirectory + Project5PathReport4,
            AssemblyDirectory + Project6PathReport4, AssemblyDirectory + Project7PathReport4, AssemblyDirectory + Project8PathReport4, AssemblyDirectory + Project9PathReport4, AssemblyDirectory + Project10PathReport4,
            AssemblyDirectory + Project11PathReport4, AssemblyDirectory + Project12PathReport4, AssemblyDirectory + Project13PathReport4, AssemblyDirectory + Project14PathReport4, AssemblyDirectory + Project15PathReport4,
            AssemblyDirectory + Project16PathReport4, AssemblyDirectory + Project17PathReport4, AssemblyDirectory + Project18PathReport4, AssemblyDirectory + Project19PathReport4, AssemblyDirectory + Project20PathReport4};
            string destinationFile = finalImagePathReport4full;

            // Specify wildcard search to match CSV files that will be combined
            for (int j = 0; j < sourceFolder.Length; j++)
            {
                string[] filePaths = Directory.GetFiles(sourceFolder[j], "Report4Item.csv");
                StreamWriter fileDest = new StreamWriter(destinationFile, true);

                int i;
                for (i = 0; i < filePaths.Length; i++)
                {
                    string file = filePaths[i];

                    string[] lines = File.ReadAllLines(file);

                    if (j > 0 || i > 0)
                    {
                        lines = lines.Skip(1).ToArray(); // Skip header row for all but first file
                    }

                    foreach (string line in lines)
                    {
                        fileDest.WriteLine(line);
                    }
                }
                fileDest.Close();
            }
        }

        private static void Report3Merge()
        {
            string[] sourceFolder = new string[] {
            AssemblyDirectory + Project1PathReport3, AssemblyDirectory + Project2PathReport3, AssemblyDirectory + Project3PathReport3, AssemblyDirectory + Project4PathReport3, AssemblyDirectory + Project5PathReport3,
            AssemblyDirectory + Project6PathReport3, AssemblyDirectory + Project7PathReport3, AssemblyDirectory + Project8PathReport3, AssemblyDirectory + Project9PathReport3, AssemblyDirectory + Project10PathReport3,
            AssemblyDirectory + Project11PathReport3, AssemblyDirectory + Project12PathReport3, AssemblyDirectory + Project13PathReport3, AssemblyDirectory + Project14PathReport3, AssemblyDirectory + Project15PathReport3,
            AssemblyDirectory + Project16PathReport3, AssemblyDirectory + Project17PathReport3, AssemblyDirectory + Project18PathReport3, AssemblyDirectory + Project19PathReport3, AssemblyDirectory + Project20PathReport3};
            string destinationFile = finalImagePathReport3full;

            // Specify wildcard search to match CSV files that will be combined
            for (int j = 0; j < sourceFolder.Length; j++)
            {
                string[] filePaths = Directory.GetFiles(sourceFolder[j], "Report3Item.csv");
                StreamWriter fileDest = new StreamWriter(destinationFile, true);

                int i;
                for (i = 0; i < filePaths.Length; i++)
                {
                    string file = filePaths[i];

                    string[] lines = File.ReadAllLines(file);

                    if (j > 0 || i > 0)
                    {
                        lines = lines.Skip(1).ToArray(); // Skip header row for all but first file
                    }

                    foreach (string line in lines)
                    {
                        fileDest.WriteLine(line);
                    }
                }
                fileDest.Close();
            }
        }
    
        static void Main(string[] args)
        {
            Report4Merge();
            Report3Merge();           
        }
    }
}

        
    
   

