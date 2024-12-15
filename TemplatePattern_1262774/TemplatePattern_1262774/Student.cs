using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern_1262774
{
    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Test1Score { get; set; }
        public int Test2Score { get; set; }
        public string Grade { get; set; }
        public int CompareTo(object obj)
        {
            int ret = 0;
            if (obj is Student)
            {
                ret = this.LastName.CompareTo(((Student)obj).LastName);
            }
            return ret;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " : " + Id.ToString() +
            " : " + Test1Score.ToString() + " : " +
           Test2Score.ToString();
        }
    }

}
