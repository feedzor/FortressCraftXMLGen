using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class ItemsManager
    {
        // Contains References to keys of both existing and newly created objects
        public List<String> ItemTypes { get; set; }
        public List<String> ItemObjects { get; set; }
        public List<String> ItemSprites { get; set; }
        public List<String> ItemCategories { get; set; }
        public List<Item> Items { get; set; }
        public Item CurrentItem { get; set; }

        public ItemsManager()
        {
            ItemTypes = (List<String>)Utils.Clone(ExistingIDs.ItemTypes);
            ItemObjects = (List<String>)Utils.Clone(ExistingIDs.ItemObjects);
            ItemSprites = (List<String>)Utils.Clone(ExistingIDs.ItemSprites);
            ItemCategories = (List<String>)Utils.Clone(ExistingIDs.ItemCategories);
            Items = new List<Item>();
            CurrentItem = new Item();
            Items.Add(CurrentItem);
        }

        
    }
}
