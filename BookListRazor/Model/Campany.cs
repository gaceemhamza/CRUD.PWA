using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPWA.Model
{
    public class Campany
    {
        public int Id { get; set; }

        public string Siret { get; set; }

        public string Name { get; set; }
        public string adresse { get; set; }

        public List<CampanyEmploye> CampanyEmployes { get; set; }
    }
}
