﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    internal interface ISellable
    {
        double calculatePrice();

        void show();
    }


}
