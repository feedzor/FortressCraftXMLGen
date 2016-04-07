using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GACXmlGenerator
{
    public class ResearchDataEntry
    {
        public class ItemRequirementsContainer
        {
            [XmlElement("Requirement")]
            public List<ResearchItemRequirement> Requirements { get; set; }
        }

        public class ResearchedTechsContainer
        {
            [XmlElement("Research")]
            public List<String> ResearchItems { get; set; }
        }
        

        public String Key { get; set; }
        public String Name { get; set; }
        public String IconName { get; set; }
        public String PreDescription { get; set; }
        public String PostDescription { get; set; }

        
        public ResearchedTechsContainer ResearchRequirements { get; set; }
        public ItemRequirementsContainer ProjectItemRequirements { get; set; }

        public int ResearchCost { get; set; }

        public bool IsOverride { get; set; }
        public List<String> RemoveResearchRequirements { get; set; }
        public List<ResearchItemRequirement> RemoveScanRequirements { get; set; }
        // ProjectItemRequirements>Requirement->Delete 

        public List<String> OriginalResearchRequirements { get; set; }
        public List<ResearchItemRequirement> OriginalScanRequirements { get; set; }

        public ResearchDataEntry()
        {
            
            Key = "Research_1";
            Name = "Research 1";
            IconName = "Icon1";
            PreDescription = "Pre description first useless research";
            PostDescription = "You wasted your time";
            ResearchRequirements = new ResearchedTechsContainer();
            ResearchRequirements.ResearchItems = new List<String>() { "Copper Ore", "Tin Ore" };

            ProjectItemRequirements = new ItemRequirementsContainer();
            ProjectItemRequirements.Requirements = new List<ResearchItemRequirement>() { new ResearchItemRequirement("ComplexExperimentalPod",35),
                new ResearchItemRequirement("SimplifiedExperimentalPod",15) };
            ResearchCost = 1;
            
        }

    }
}



    