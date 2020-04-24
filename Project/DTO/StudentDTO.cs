﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DTO
{
    public class StudentDTO
    {
        public string StudentId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Contact { get; set; }

        public DateTime? BirthDate { get; set; }

        public string StatusId { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
