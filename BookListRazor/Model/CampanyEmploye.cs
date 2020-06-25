using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPWA.Model
{
    public class CampanyEmploye
    {
        public int EmployeId { get; set; }
        public Employe Employe { get; set; }

        public int CampanyId { get; set; }
        public Campany Campany { get; set; }
    }
}
