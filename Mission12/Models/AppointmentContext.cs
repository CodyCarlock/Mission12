﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Mission12.Models
{
    public class AppointmentContext : DbContext
    {
        
        public AppointmentContext (DbContextOptions<GroupContext> options) : base (options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
