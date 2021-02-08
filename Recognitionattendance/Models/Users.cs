using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognitionattendance.Models
{
    class Users
    {
        public int Id { get; set; }


        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string ImageName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName } {LastName}";
            }
        }


    }
}
