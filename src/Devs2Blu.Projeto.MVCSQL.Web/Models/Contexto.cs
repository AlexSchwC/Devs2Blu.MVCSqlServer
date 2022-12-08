using Devs2Blu.Projeto.MVCSQL.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.Projeto.MVCSQL.Web.Models
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) 
			: base(options)
		{

		}

		#region DbSets

		//Inserimos a classe Entidade que criamos no Contexto
		public DbSet<Filme> Filme { get; set; }

		#endregion
	}
}
