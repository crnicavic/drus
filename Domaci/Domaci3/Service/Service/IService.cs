using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace Service
{
    [ServiceContract]
    public interface IPublisher
    {
        [OperationContract(IsOneWay = true)]
        void Publish();
    }

    [ServiceContract(CallbackContract = typeof(ICallback))]
    public interface ISubscriber
    {
        [OperationContract(IsOneWay = true)]
        void initHMI(string variable);
    }

    [ServiceContract]
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void onNotify(string variable, string address, double value);
    }
}
