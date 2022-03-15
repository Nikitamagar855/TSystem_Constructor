using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Constructor
{
   public class Student
    {
        private int id;
        private string name, Standard, address;

        public Student()
        {
            id = 101;
            name = "Swami";
            Standard = "5th";
            address = "Malegaon";

        }
        public Student(int s_id,string s_name, string s_Standard,string s_address)
        {
            id = s_id;
            name = s_name;
            Standard = s_Standard;
            address = s_address;

        }
        public string GetData()
        {
            return "Studid" + id  +" " +   "StudName" +    name   + " "+  "Standard"  +" " +   Standard   + " "+  " StudAddress"   +   address;
        }
    } 
}
