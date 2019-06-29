﻿using System;
using System.Collections.Generic;
using WM.Northwind.Entities.ComplexTypes.EczaneNobet;
using WM.Northwind.Entities.Concrete.Authorization;
using WM.Northwind.Entities.Concrete.EczaneNobet;

namespace WM.UI.Mvc.Areas.EczaneNobet.Models
{
    public class KonumDetayViewModel
    {      
        public List<KonumDetay> KonumDetaylar { get; set; }
        public List<UserRoleDetay> UserRoleDetaylar { get; set; }
    }
}