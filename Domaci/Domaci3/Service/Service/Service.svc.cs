using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IPublisher, ISubscriber
    {
        delegate void MessageDelegate(string variable, string address, double value);
        static event MessageDelegate messageArrivedEvent;

        static Dictionary<int, ICallback> panelCallbacks = new Dictionary<int, ICallback>();
        static Dictionary<int, Panel> panels = new Dictionary<int, Panel>();
        static Dictionary<string, string> addressTable = new Dictionary<string, string>
        {
            { "ADDR01", "Temperature" },
            { "ADDR02", "Speed" },
            { "ADDR03", "Pressure"}
        };


        public void Publish()
        {
            Random rnd = new Random();
            List<int> idsToNotify = new List<int>(panels.Keys.ToList<int>());
            foreach (var addr in addressTable)
            {
                double value = 100 * rnd.NextDouble();
                foreach (var panel in panels.Values)
                {
                    if (panel.variable != addr.Value && panel.variable != addr.Key)
                    {
                        continue;
                    }
                    panelCallbacks[panel.id].onNotify(addr.Value, addr.Key, value);
                    idsToNotify.Remove(panel.id);
                }
            }

            foreach (var id in idsToNotify)
            {
                panelCallbacks[id].onNotify(panels[id].variable, panels[id].address, 0);
            }
        }

        public void initHMI(string v)
        {
            Panel p = new Panel();
            if (addressTable.ContainsKey(v))
            {
                p.variable = addressTable[v];
                p.address = v;
            }
            else if (addressTable.ContainsValue(v))
            {
                p.variable = v;
                p.address = addressTable.FirstOrDefault(a => a.Value == v).Key;
            }
            else
            {
                if (v.Contains("ADDR"))
                {
                    p.address = v;
                    p.variable = "??";
                }
                else
                {
                    p.address = "??";
                    p.variable = v;
                }
            }
            p.id = panels.Count;
            var callback= OperationContext.Current.GetCallbackChannel<ICallback>();
            panelCallbacks[p.id] = callback;
            panels[p.id] = p;
            // ili ovde treba callback?
        }
    }

    class Panel
    {
        // cisto da ih razlikujem
        public int id;

        // promenljiva koju prate
        public string variable;

        // adresa promenljive
        public string address;
    }
}
