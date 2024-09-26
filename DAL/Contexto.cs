using Microsoft.EntityFrameworkCore;
using JoseBrito_AP1_P1.Models;

namespace JoseBrito_AP1_P1.DAL
{
	public class Contexto : DbContext
	{
		DbSet<Registro> Registro { get; set; }
		public Contexto(DbContextOptions<Contexto> options) : base(options) { }
	}
}
