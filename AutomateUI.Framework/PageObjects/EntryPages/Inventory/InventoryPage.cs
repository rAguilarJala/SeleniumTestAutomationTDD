using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateUI.Framework.PageObjects.EntryPages.Inventory
{
    public class InventoryPage : EntryPageBase
    {
        public List<ProductCard> ProductCards => SelectAll<ProductCard>(".inventory_item");

    }
}
