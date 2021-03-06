﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string TipoSangre { get; set; }
        public List<ConsultationRecord> consulRecord { get; set; }
        public List<TestHistory> TestHistory { get; set; }
        public List<ActiveMedication> activeMedication { get; set; } 


    }

  
}
