using BatchPlant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BatchPlantWPF
{
    [DataContract(Namespace = Namespaces.BatchPlant)]       // za serilizaciju
    public class BatchPlantServerConfiguration
    {
        public BatchPlantServerConfiguration() // postavlja podrazumevane vrednosti za clanove klase
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context) // prilikom deserilizacije (ucitavanje podataka u objekat) inicijalizuje
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            timeout = 30;
            endpoint = "opc.tcp://localhost:4840";
        }
        private int timeout;
        private string endpoint;
    }

    
}
