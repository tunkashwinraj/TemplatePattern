using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_1262774
{
    class StudentProcessingViaFile2 : TemplateStudent
    { // combining template and strategy patterns to make
      // part of the algorithm step pluggable.
        string inFileName = "";
        string outFileName = "";
        IGradeStrategy igradeStrategy; // flexible grade strategy
        public StudentProcessingViaFile2(string infName, string outfName,
        IGradeStrategy igr)
        {
            inFileName = infName;
            outFileName = outfName;
            igradeStrategy = igr;
        }
        public override void ReadStudents()
        {
            FileInfo fi = new FileInfo(inFileName);
            StreamReader sr = fi.OpenText();
            char[] seps = { ',' };
            string sline = sr.ReadLine();
            while (sline != null)
            {
                string[] parts = sline.Split(seps, 5);
                Student s1 = new Student();
                s1.FirstName = parts[0].Trim();
                
            s1.LastName = parts[1].Trim();
                s1.Id = int.Parse(parts[2]);
                s1.Test1Score = int.Parse(parts[3]);
                s1.Test2Score = int.Parse(parts[4]);
                _STList.Add(s1);
                sline = sr.ReadLine();
            }
            sr.Close();
        }
        public override void AssignGrades()
        {
            foreach (Student st in _STList)
            {
                st.Grade = igradeStrategy.ComputeGrade(st);
            }
        }
        public override void SortStudents()
        {
            _STList.Sort(); // could be Shell sort
        }
        public override void StoreStudents()
        {
            FileInfo fi = new FileInfo(outFileName);
            StreamWriter sw = new StreamWriter(fi.Open(FileMode.OpenOrCreate,
           FileAccess.Write));
            foreach (Student st in _STList)
            {
                sw.WriteLine(st.FirstName + "\t" +
                st.LastName + "\t" + st.Id.ToString() + "\t" +
                st.Test1Score.ToString() + "\t" +
                st.Test2Score.ToString() + "\t" + st.Grade);
            }
            sw.Close();
        }
    }

}
