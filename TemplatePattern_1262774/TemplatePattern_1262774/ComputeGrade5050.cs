using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_1262774
{
    class ComputeGrade5050 : IGradeStrategy // concrete strategy
    {

        public string ComputeGrade(Student st)
        {
            string grade = "";
            double avg = 0.5 * st.Test1Score + 0.5 * st.Test2Score;
            if (avg > 90)
                grade = "A";
            else if (avg > 85)
                grade = "A-";
            else if (avg > 80)
                grade = "B+";
            else
                grade = "B";
            return grade;
        }
    }
}
