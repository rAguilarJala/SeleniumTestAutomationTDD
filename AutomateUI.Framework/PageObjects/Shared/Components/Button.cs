using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateUI.Framework.PageObjects.Shared.Components
{
    public class Button : PomBase
    {
        public void Click() {
            RelatedElement.Click();
        }
    }
}
