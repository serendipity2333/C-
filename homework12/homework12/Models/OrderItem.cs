using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace homework12.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int SingalPrice { get; set; }
        public int Amount { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Order Order { get; set; }
    }
}
