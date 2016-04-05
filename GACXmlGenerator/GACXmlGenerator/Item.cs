using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class Item
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Plural { get; set; }
        public string Type { get; set; }
        public string Object { get; set; }
        public string Sprite { get; set; }
        public string Category { get; set; }
        public List<string> ResearchRequirements { get; set; }
        public List<string> ScanRequirements { get; set; }

        public Item()
        {
            Key = "Anton.Test";
            Name = "Item1";
            Plural = "Items1";
            Type = "Type1";
            Object = "Object1";
            Sprite = "Sprite1";
            Category = "Category1";
            ResearchRequirements = new List<string>() { "RR1", "RR2" };
            ScanRequirements = new List<string>() { "SR1", "SR2" };
        }
    }
}
