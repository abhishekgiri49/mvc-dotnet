﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MovieRental.ModifiedClass.Setup
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext")
        {
        }

    }
}