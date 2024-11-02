﻿using AutomateUI.Framework.PageObjects.Shared.Components;
using AutomateUI.Framework.PageObjects.Shared.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateUI.Framework.PageObjects.EntryPages.Login
{
    public class LoginPage : EntryPageBase
    {
        public TextField Username => Select<TextField>("#user-name");
        public TextField Password => Select<TextField>("#password");

        public Button LoginButton => Select<Button>("#login-button");
    }
}
