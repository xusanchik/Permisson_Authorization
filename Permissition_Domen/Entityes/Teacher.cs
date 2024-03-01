﻿using Permission_Domen.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission_Domen.Entityes
{
    public class Teacher: AuditTable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
        public string Price { get; set; }
        public string PhoneNumber { get; set; }
    }
}
