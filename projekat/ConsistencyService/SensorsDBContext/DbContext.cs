using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;

namespace SensorsDatabaseContext
{
    public class DBInfo_Sensor
    {
        [Key]
        public int id { get; set; }
        public double temperature { get; set; }
        public DateTime timestamp { get; set; }

        // who "wrote" the data to the table, sensor or consistencyManager
        public string source { get; set; }
    }

    public class DBInfo_Sensor1 : DBInfo_Sensor { }
    public class DBInfo_Sensor2 : DBInfo_Sensor { }
    public class DBInfo_Sensor3 : DBInfo_Sensor { }
    public class DBInfo_Sensor4 : DBInfo_Sensor { }
    public class DBInfo_Sensor5 : DBInfo_Sensor { }
    public class DBInfo_Sensor6 : DBInfo_Sensor { }
    public class DBInfo_Sensor7 : DBInfo_Sensor { }
    public class DBInfo_Sensor8 : DBInfo_Sensor { }
    public class DBInfo_Sensor9 : DBInfo_Sensor { }
    public class DBInfo_Sensor10 : DBInfo_Sensor { }
    public class SensorsDBContext : DbContext
    {
        public DbSet<DBInfo_Sensor1> SensorTable1 { get; set; }
        public DbSet<DBInfo_Sensor2> SensorTable2 { get; set; }
        public DbSet<DBInfo_Sensor3> SensorTable3 { get; set; }
        public DbSet<DBInfo_Sensor4> SensorTable4 { get; set; }
        public DbSet<DBInfo_Sensor5> SensorTable5 { get; set; }
        public DbSet<DBInfo_Sensor6> SensorTable6 { get; set; }
        public DbSet<DBInfo_Sensor7> SensorTable7 { get; set; }
        public DbSet<DBInfo_Sensor8> SensorTable8 { get; set; }
        public DbSet<DBInfo_Sensor9> SensorTable9 { get; set; }
        public DbSet<DBInfo_Sensor10> SensorTable10 { get; set; }

    }
}
