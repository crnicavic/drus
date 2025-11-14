using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ConsistencyService
{
    public class ConsistencyService: IPublisher, ISubscriber
    {
        public void publishTemp(SensorInfo t)
        {

        }

        public SensorInfo querySensor(int id)
        {
            return null;
        }
    }
}
