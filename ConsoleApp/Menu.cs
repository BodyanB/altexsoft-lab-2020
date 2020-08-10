using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
    class Menu
    {
        #region Private Members
        private List<string> m_datafromfile = new List<string>();
      
        private string[] m_filepaths;

        #endregion


        #region Constructor
        public Menu()
        {
           
        }
        #endregion

        #region Public Properties
        public List<string> MAINMENUFILEDATA
        {
            get
            {
                return m_datafromfile;
            }
            set
            {
                m_datafromfile = value;
            }

        }
        public string[] FILEPATHS
        {
            get
            {
                return m_filepaths;
            }
            set
            {
                m_filepaths = value;
            }

        }

        #endregion

        #region Public Member Functions

        private void readRelaventFile()
        {

            readFilesPath();
            ReadDataFromMainFile();


        }

        public void showMenuScreen()
        {
            string autndate = "Author: N/A\t\t\t\t\t  Date:" + System.DateTime.Now;
            readRelaventFile();
            
            if (!MAINMENUFILEDATA.Contains(autndate))
            {
                MAINMENUFILEDATA.Insert(1, autndate);
            }
        top: foreach (string item in MAINMENUFILEDATA)
            {
                Console.WriteLine(item);
            }
        up:
            int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception) 
            {
                Console.WriteLine("You have not entered a number");
            }
            
            switch (n)
            {
                case 1:
                    Console.Clear();
                    ReadText rt = new ReadText();
                    rt.RText();
                    break;
                case 2:
                    Console.Clear();
                    CountWord cw = new CountWord();
                    cw.CWord();
                    break;
                case 3:
                    Console.Clear();
                    ThirdSentence ts = new ThirdSentence();
                    ts.TSentence();
                    break;
                case 4:
                    Console.Clear();
                    FolderName fn = new FolderName();
                    fn.FName();
                    break;               
                case 5:
                    Console.Clear();
                    Console.WriteLine("Exit");
                    return;
                //break;
                default:
                    Console.WriteLine("Please enter correct number");
                    goto up;
                    //break;
            }

            Console.WriteLine("Please type r to return to main menu or e to exit");
        input: string r = Console.ReadLine();
            if (r.ToLower() == "r")
            {
                Console.Clear();
                goto top;
            }
            else if (r.ToLower() == "e")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter correct value either r or e`");
                goto input;
            }
        }

        #endregion

        #region Private Member Functions
        private void ReadDataFromMainFile()
        {
            string path = FILEPATHS.First(p => p.Contains("Main"));
            StreamReader srObj = new StreamReader(path);

            string line = srObj.ReadLine();

            while (line != null)
            {
                MAINMENUFILEDATA.Add(line);
                line = srObj.ReadLine();

            }


        }

        public void readFilesPath()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            path += "files";
            
            FILEPATHS = Directory.GetFiles(path);
                     
        }

        #endregion


    }
}
