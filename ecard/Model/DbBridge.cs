using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ecard.Model
{
	public class DbBridge : DbContext
	{
		public DbBridge() { }
		public DbBridge(DbContextOptions<DbBridge> options) : base(options) { }
		public DbSet<Greetings> Greetings { get; set; }
		public DbSet<Favorites> Favorites { get; set; }

	}
}
