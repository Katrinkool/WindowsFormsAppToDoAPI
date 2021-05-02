using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppToDoAPI.DTO
{
    class User
    {
        public int? id { get; set; }     //? tähendab et väärtus võib olla ka null ehk tyhi
        public string username { get; set; }
        public string password { get; set; }
        public string access_token { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string created_at { get; set; }
        
        //tuleb errori korral
        public string message { get; set; }  //error message

    }
}
