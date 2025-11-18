using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ConsistencyService
{
    [DataContract]
    public class TemperatureInfo
    {
        [DataMember(Order = 1, IsRequired = true)]
        public int sensor_id;
        [DataMember(Order = 2, IsRequired = true)]
        public double temperature;
        [DataMember(Order = 3, IsRequired = true)]
        public DateTime timestamp;
        [DataMember(Order = 4, IsRequired = true)]
        public string source;
    }

    [ServiceContract]
    public interface IPublisher
    {
        [OperationContract(IsOneWay = true)]
        void publishTemp(TemperatureInfo t);
    }

    [ServiceContract]
    public interface ISubscriber
    {
        [OperationContract]
        TemperatureInfo querySensor(int id);
    }

}

    

