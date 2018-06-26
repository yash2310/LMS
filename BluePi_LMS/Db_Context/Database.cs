using BluePi_Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BluePi_LMS.Db_Context
{
	public class Database : DbContext
	{
		public Database() : base("name=lmsconnection")
		{
		}

		public DbSet<Account> Accounts { get; set; }
		public DbSet<Employee> Employees { get; set; }
		//public DbSet<Designation> Designations { get; set; }
		//public DbSet<Department> Departments { get; set; }
		//public DbSet<Organization> Organizations { get; set; }
		//public DbSet<Role> Roles { get; set; }
		//public DbSet<Branch> Branches { get; set; }
		//public DbSet<Leave> Leaves { get; set; }
		//public DbSet<LeaveType> LeaveTypes { get; set; }
		//public DbSet<LeaveCategory> LeaveCategories { get; set; }
		//public DbSet<LeaveStatus> LeaveStatuses { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Account>().HasKey(a => a.Id);
			modelBuilder.Entity<Employee>().HasKey(a => a.Id);
			modelBuilder.Entity<Designation>().HasKey(a => a.Id);
			modelBuilder.Entity<Department>().HasKey(a => a.Id);
			modelBuilder.Entity<Organization>().HasKey(a => a.Id);
			modelBuilder.Entity<Role>().HasKey(a => a.Id);
			modelBuilder.Entity<Branch>().HasKey(a => a.Id);
			modelBuilder.Entity<Leave>().HasKey(a => a.Id);
			modelBuilder.Entity<LeaveType>().HasKey(a => a.Id);
			modelBuilder.Entity<LeaveCategory>().HasKey(a => a.Id);
			modelBuilder.Entity<LeaveStatus>().HasKey(a => a.Id);

			modelBuilder.Entity<Account>().HasRequired(a => a.Employee).WithRequiredDependent(e => e.Account);

			modelBuilder.Entity<Employee>().HasRequired(a => a.Department).WithRequiredDependent(d=>d.Employee);

			modelBuilder.Entity<Employee>().HasRequired(a => a.Designation).WithRequiredDependent(d => d.Employee);

			modelBuilder.Entity<Employee>().HasRequired(a => a.Organization).WithRequiredDependent(d => d.Employee);

			modelBuilder.Entity<Employee>().HasRequired(a => a.Branch).WithRequiredDependent(d => d.Employee);

			modelBuilder.Entity<Employee>().HasRequired(a => a.Role).WithRequiredDependent(d => d.Employee);

			//modelBuilder.Entity<Leave>().HasRequired(a => a.Type).WithRequiredDependent(d => d.Employee);
			//modelBuilder.Entity<Leave>().HasRequired(a => a.Status).WithRequiredDependent(d => d.Employee);
			//modelBuilder.Entity<Leave>().HasRequired(a => a.Category).WithRequiredDependent(d => d.Employee);

		}
	}
}