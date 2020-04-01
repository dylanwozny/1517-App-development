using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using FSISSystem.DWOZ.Enitites;
using System.Data.Entity;
#endregion

namespace FSISSystem.DWOZ.DAL
{
    internal class FSISSystemContext:DbContext
    {

        public FSISSystemContext():base("FSIS_db")
        {

        }

        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }



    }
}
