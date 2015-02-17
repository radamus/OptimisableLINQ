﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimisableLINQ
{
    class OptimizationFatalException : Exception
    {
        
        public OptimizationFatalException(string p):base(p)
        {
         
        }

        public OptimizationFatalException(string p, Exception e):base(p,e)
        {
            
        }
    }
}
