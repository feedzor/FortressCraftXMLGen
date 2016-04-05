using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class FilesLocations
    {
        private ModConfiguration modProperties;

        public String VersionedRootPath {
            get { return Path.Combine(modProperties.Location, modProperties.ID, modProperties.Version);  }
        }

        public String ModConfigFilePath
        {
            get { return Path.Combine(VersionedRootPath, "mod.config");  }
        }

        public FilesLocations(ModConfiguration modProperties)
        {
            this.modProperties = modProperties;
        }
    }

    
}
