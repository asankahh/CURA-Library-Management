using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CuraService
{
    [DataContract]    
    public class Book
    {
        [DataMember]
        public string BookId { get; set; }
        [DataMember]
        public string BookName { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string ISBN { get; set; }
        [DataMember]
        public string Edition { get; set; }
        [DataMember]
        public string Publisher { get; set; }
        [DataMember]
        public string Year { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public byte[] img { get; set; }

    }
}
