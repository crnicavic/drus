using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SensorsDatabaseContext;

namespace ConsistencyService
{
    public class ConsistencyService: IPublisher, ISubscriber
    {
        public SensorsDBContext context = new SensorsDBContext();
        public void publishTemp(TemperatureInfo t)
        {
            DBInfo_Sensor row;

            switch (t.sensor_id)
            {
                case 1: row = new DBInfo_Sensor1(); break;
                case 2: row = new DBInfo_Sensor2(); break;
                case 3: row = new DBInfo_Sensor3(); break;
                case 4: row = new DBInfo_Sensor4(); break;
                case 5: row = new DBInfo_Sensor5(); break;
                case 6: row = new DBInfo_Sensor6(); break;
                case 7: row = new DBInfo_Sensor7(); break;
                case 8: row = new DBInfo_Sensor8(); break;
                case 9: row = new DBInfo_Sensor9(); break;
                case 10: row = new DBInfo_Sensor10(); break;
                default: throw new Exception("INVALID SENSOR ID!");
            }

            row.timestamp = t.timestamp;
            row.temperature = t.temperature;
            row.source = t.source;

            switch (t.sensor_id)
            {
                case 1: context.SensorTable1.Add((DBInfo_Sensor1) row); break;
                case 2: context.SensorTable2.Add((DBInfo_Sensor2) row); break;
                case 3: context.SensorTable3.Add((DBInfo_Sensor3) row); break;
                case 4: context.SensorTable4.Add((DBInfo_Sensor4) row); break;
                case 5: context.SensorTable5.Add((DBInfo_Sensor5) row); break;
                case 6: context.SensorTable6.Add((DBInfo_Sensor6) row); break;
                case 7: context.SensorTable7.Add((DBInfo_Sensor7) row); break;
                case 8: context.SensorTable8.Add((DBInfo_Sensor8) row); break;
                case 9: context.SensorTable9.Add((DBInfo_Sensor9) row); break;
                case 10: context.SensorTable10.Add((DBInfo_Sensor10) row); break;
                default: throw new Exception("INVALID SENSOR ID!");
            }

            context.SaveChanges();
        }

        public TemperatureInfo querySensor(int id)
        {
            DBInfo_Sensor row;
            switch (id)
            {
                case 1: row = context.SensorTable1.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 2: row = context.SensorTable2.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 3: row = context.SensorTable3.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 4: row = context.SensorTable4.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 5: row = context.SensorTable5.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 6: row = context.SensorTable6.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 7: row = context.SensorTable7.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 8: row = context.SensorTable8.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 9: row = context.SensorTable9.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                case 10: row = context.SensorTable10.OrderByDescending(t => t.timestamp).FirstOrDefault(); break;
                default: throw new Exception("INVALID SENSOR ID!");

            }

            // if there is nothing return zeroes just to prevent crashes
            TemperatureInfo result = new TemperatureInfo();
            if (row != null)
            {
                result.timestamp = row.timestamp;
                result.temperature = row.temperature;
                result.source = row.source;
                result.sensor_id = id;
            }
            return result;
        }

    }
}
