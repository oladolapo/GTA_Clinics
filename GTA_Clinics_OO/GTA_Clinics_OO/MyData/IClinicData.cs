using GTA_Clinics_OO.OOModels;

namespace GTA_Clinics_OO.MyData
{
    public interface IClinicData
    {
        List<ClinicOO> GetClinicss(Guid id);
        ClinicOO GetClinic(ClinicOO clinic);
        ClinicOO AddClinic(ClinicOO clinic);
        void DeleteClINIC (ClinicOO clinic);
        ClinicOO EditClinic(ClinicOO clinic);
        object GetClinic(Guid id);
        object? GetClinicss();
    }
}
