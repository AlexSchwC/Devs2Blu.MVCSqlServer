using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.Projeto.MVCSQL.Web.Models.Entities
{
	//Property Annotation
	[Table("Filmes")]
	public class Filme
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("title")]
		[Display(Name = "Título")]
		public string Title { get; set; }

		[Column("genre")]
		[Display(Name = "Gênero")]
		public string Genero { get; set; }
	}
}
