using GTA_Clinics_OO.OOModels;

namespace GTA_Clinics_OO.MyData
{
    public class MockClinicData : IClinicData
    {
        public List<ClinicOO> customers = new List<ClinicOO>()
            {
            new ClinicOO()
            {
                Id= Guid.NewGuid(),
                ClinicName = "Dolapo",
                Dateregistered = "2023",
                ClinicPhone = "905",
                ClinicAddress= "FENELL",
                Description = "Family Clinic",

            },
            new ClinicOO()
            {
                Id = Guid.NewGuid(),
                ClinicName = "Ogunsipe",
                Dateregistered = "2023",
                ClinicPhone = "902",
                ClinicAddress= "Missisauga",
                Description = "Private clinic",
            }
        };
        public ClinicOO AddClinic(ClinicOO clinic)
        {
            clinic.Id = Guid.NewGuid();
            GetClinicss.Add(clinic);
            return clinic;
        }

        public void DeleteClINIC(ClinicOO clinic)
        {
            throw new NotImplementedException();
        }

        public ClinicOO EditClinic(ClinicOO clinic)
        {
            throw new NotImplementedException();
        }

        public ClinicOO GetClinic(ClinicOO clinic)
        {
            throw new NotImplementedException();
        }

        public object GetClinic(Guid id)
        {
            return ClinicOO.SingleOrDefault(x => x.Id == id);
        }

        public List<ClinicOO> GetClinicss()
        {
            return GetClinicss();
        }

        public List<ClinicOO> GetClinicss(Guid id)
        {
            throw new NotImplementedException();
        }

        object? IClinicData.GetClinicss()
        {
            throw new NotImplementedException();
        }
    }
}
