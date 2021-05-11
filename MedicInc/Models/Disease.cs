using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicInc.Models
{
    public class Disease
    {
        public Disease()
        {
        }

        public Disease(int diseaseID, string name, string symptom, string info)
        {
            DiseaseID = diseaseID;
            Name = name;
            Symptom = symptom;
            Info = info;
        }

        public int DiseaseID { get; set; }
        public string Name { get; set; }
        public string Symptom { get; set; }
        public string Info { get; set; }
    }
}