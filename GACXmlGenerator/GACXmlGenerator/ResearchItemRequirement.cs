using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GACXmlGenerator
{
    [XmlRoot("Requirement")]
    public class ResearchItemRequirement
    {
        public String Key { get; set; }
        public int Amount { get; set; }

        public ResearchItemRequirement() { }

        public ResearchItemRequirement(String key, int amount)
        {
            this.Key = key;
            this.Amount = amount;
        }
    }
}
