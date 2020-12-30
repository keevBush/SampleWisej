using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class DataContext:DbContext
    {
        private static DataContext _instance = null;
        public static DataContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataContext();
                return _instance;
            }
        }

        public DataContext() : base("database")
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }

}