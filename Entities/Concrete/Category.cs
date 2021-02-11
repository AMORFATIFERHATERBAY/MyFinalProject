﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

    }
}
