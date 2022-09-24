using JayTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;


namespace JayTracker.Data;

public class JayTrackerContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public string DbPath { get; }

    public JayTrackerContext()
    {   
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=JayTracker.db");
}