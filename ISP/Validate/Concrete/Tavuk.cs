﻿using ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Validate.Concrete
{
    public class Tavuk : IYuruyebilir, IKosabilir
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
}
