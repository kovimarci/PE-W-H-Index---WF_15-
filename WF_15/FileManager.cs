using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace WF_15
{
    class FileManager
    {
        private string filename;
        public FileManager(string FileIn)
        {
            filename = FileIn;
        }
        public List<Person> ReadFile()
        {
            List<Person> returnlist = new List<Person>();
            try
            {
                StreamReader r = new StreamReader(filename);
                r.ReadLine();
                while (!r.EndOfStream)
                {
                    returnlist.Add(new Person(r.ReadLine()));
                }
                r.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Error message"); }
            return returnlist;
        }
        public void WriteFile(List<Person> all)
        {
            try
            {
                StreamWriter w = new StreamWriter(filename, false, Encoding.UTF8);
                w.WriteLine("elsosor");
                foreach (Person p in all)
                {
                    w.WriteLine(p.Weight + "-" + p.Height);
                }
                w.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Error message"); }
        }
    }
}
