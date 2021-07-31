﻿using AluraFlix.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.Domain
{
    public class Category
        : EntityBase
    {

        public string Title { get; set; }
        public string Color { get; set; }

    }
}
