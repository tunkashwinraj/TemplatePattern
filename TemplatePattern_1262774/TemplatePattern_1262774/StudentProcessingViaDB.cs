using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_1262774
{
    class StudentProcessingViaDB : TemplateStudent
    {
        public override void ReadStudents()
        {
            string sql = "select * from Students";
            DataTable dt = DataAccess.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Student s1 = new Student();
                s1.FirstName = dt.Rows[i]["FirstName"].ToString();
                s1.LastName = dt.Rows[i]["LastName"].ToString();
                s1.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                s1.Test1Score =
               int.Parse(dt.Rows[i]["Test1Score"].ToString());
                s1.Test2Score =
               int.Parse(dt.Rows[i]["Test2Score"].ToString());
                _STList.Add(s1);
            }
        }
        public override void AssignGrades()
        {
            foreach (Student st in _STList)
            { // different formula
                string grade = "";
                double avg = 0.5 * st.Test2Score + 0.5 * st.Test2Score;
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
            // doesn't matter because data is being written to DB
        }
        public override void StoreStudents()
        {
            foreach (Student st in _STList)
            {
                string sql = "Update Students set " +
                "FirstName='" + st.FirstName + "'," +
                "Lastname='" + st.LastName + "'," +
                "Test1Score=" + st.Test1Score + "," +
                "Test2Score=" + st.Test2Score + "," +
                "Grade='" + st.Grade + "' where Id=" + st.Id.ToString();
                DataAccess.InsertOrUpdateOrDelete(sql);
            }
        }
    }
}
