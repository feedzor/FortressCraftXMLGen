using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class ResearchManager
    {
        public List<ResearchDataEntry> dataEntries;
        private String researchDataPath;
        public bool IsOriginalResearchLoaded { get; set; }

        public ResearchManager()
        {
        }

 
        public bool loadResearch(String originalResearchFilePath)
        {
            dataEntries = XMLSerializer.Deserialize<List<ResearchDataEntry>>(File.ReadAllText(originalResearchFilePath));
            if (dataEntries != null)
            {
                researchDataPath = originalResearchFilePath;
                IsOriginalResearchLoaded = true;
                return IsOriginalResearchLoaded;
            }
            else
            {
                researchDataPath = null;
                IsOriginalResearchLoaded = false;
                return IsOriginalResearchLoaded;
            }


        }
    }
}
