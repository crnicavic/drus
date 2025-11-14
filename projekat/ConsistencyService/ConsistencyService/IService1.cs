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
    public class SensorInfo
    {
        [DataMember(Order = 1, IsRequired = true)]
        public int publisher_id;
        [DataMember(Order = 2, IsRequired = true)]
        public float temperature;
        [DataMember(Order = 3, IsRequired = true)]
        public DateTime timestamp;
    }

    [ServiceContract]
    public interface IPublisher
    {
        [OperationContract(IsOneWay = true)]
        void publishTemp(SensorInfo t);
    }

    [ServiceContract]
    public interface ISubscriber
    {
        [OperationContract(IsOneWay = true)]
        SensorInfo querySensor(int id);
    }

}

    

