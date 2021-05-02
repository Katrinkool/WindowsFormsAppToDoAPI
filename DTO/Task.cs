using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppToDoAPI.DTO
{
    class Task
    {
        public int? id { get; set; }  //? tähendab et väärtus võib olla ka null ehk tyhi
        public string title { get; set; }
        public string desc { get; set; }
        public bool marked_as_done { get; set; }
        public string created_at { get; set; }

        //tuleb errori korral
        public string message { get; set; }  //error message


    }
}
