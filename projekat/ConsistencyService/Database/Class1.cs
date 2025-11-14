using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;

namespace Database
{
    public class DB_SensorInfo
    {
        public int id { get; set; }
        public int publisher_id { get; set; }
        public double temperature { get; set; }
        public DateTime timestamp { get; set; }
    }
    public class SensorDBContext : DbContext
    {
        public DbSet<DB_SensorInfo> SensorTable1 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable2 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable3 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable4 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable5 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable6 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable7 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable8 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable9 { get; set; }
        public DbSet<DB_SensorInfo> SensorTable10 { get; set; }

    }
}
