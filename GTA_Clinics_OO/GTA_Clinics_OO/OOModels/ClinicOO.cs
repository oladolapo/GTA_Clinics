using System.Runtime.Serialization;

namespace GTA_Clinics_OO.OOModels
{
    public class ClinicOO
    {
        public Guid  Id { get; set; }
        public string ClinicName { get; set; }
        public string Dateregistered {get; set; }
        public string ClinicPhone { get; set; }
        public string ClinicAddress { get; set; }
        public string Description { get; set; }

        internal static object SingleOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
