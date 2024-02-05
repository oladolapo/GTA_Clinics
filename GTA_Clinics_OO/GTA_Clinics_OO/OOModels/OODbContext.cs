using Microsoft.EntityFrameworkCore;

namespace GTA_Clinics_OO.OOModels
{
    public class OODbContext :DbContext
    {
        public DbSet<ClinicOO> ClinicOO { get; set; }

        public DbSet<FundOO> FundOO { get; set; }

    }
}
