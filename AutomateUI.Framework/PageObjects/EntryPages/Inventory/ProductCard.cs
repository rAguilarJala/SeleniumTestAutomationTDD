using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateUI.Framework.PageObjects.EntryPages.Inventory
{
    public class ProductCard : PomBase
    {
        public string Title => GetText(".inventory_item_name");
    }
}
