﻿using ProjectPractice.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Domain.Exceptions.BadRequest
{
    public class InvalidFieldException: CustomException
    {
        public InvalidFieldException(ExceptionEnum message) : base(message) { }
    }
}
