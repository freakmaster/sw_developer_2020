﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    class CalculationImpossibleException : Exception
    {
        private string _invalidParameter;

        public CalculationImpossibleException(string invalidParameter)
            : base()
        {
            _invalidParameter = invalidParameter;
        }

        public override string Message
        {
            get
            {
                return $"Parameter '{_invalidParameter}' hat einen ungültigen Inhalt.";
            }
        }

    }
}
