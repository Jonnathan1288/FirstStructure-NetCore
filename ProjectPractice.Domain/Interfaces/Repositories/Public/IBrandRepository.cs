﻿using EFCommonCRUD.Interfaces;
using ProjectPractice.Domain.Entities.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Domain.Interfaces.Repositories.Public
{
    public interface IBrandRepository : INPRepository<Brand, int>
    {
    }
}
