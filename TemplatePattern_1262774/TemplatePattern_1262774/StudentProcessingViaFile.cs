using System;
using System.Collections.Generic;
using System.IO;

namespace TemplatePattern_1262774
{
    class StudentProcessingViaFile : TemplateStudent
    {
        string inFileName = "";
        string outFileName = "";
        public StudentProcessingViaFile(string infName, string outfName)
        {
            inFileName = infName;
            outFileName = outfName;
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
                string grade = "";
                double avg = 0.4 * st.Test1Score + 0.6 * st.Test2Score; // Adjusted formula
                if (avg > 90)
                    grade = "A";
                else if (avg > 85)
                    grade = "A-";
                else if (avg > 80)
                    grade = "B+";
                else
                    grade = "B";
                st.Grade = grade;
            }
        }

        public override void SortStudents()
        {
            _STList.Sort(); // could be Shell sort
        }

        public override void StoreStudents()
        {
            FileInfo fi = new FileInfo(outFileName);
            StreamWriter sw = new StreamWriter(fi.Open(FileMode.OpenOrCreate, FileAccess.Write));
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
