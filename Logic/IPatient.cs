using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IPatient
    {
        List<Patient> GetUserPatients(string username);
        List<Patient> GetPatients(string nameFilter, string username);
    }
}
