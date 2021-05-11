using MedicInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicInc.Services
{
    public class DiseaseService
    {
        DiseaseContext db = new DiseaseContext();
        public Disease SerchDiseaseInDB(string symptom)
        {
            Disease disease = (from c in db.Disease where c.Symptom == symptom select c).FirstOrDefault();
            return disease;
        }
    }
}