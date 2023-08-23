using Microsoft.EntityFrameworkCore;

namespace EdificioBackEnd.Models;

public class BDContext : DbContext
{
	public static string DefaultConnection
	{
		get
		{
			var server = "localhost";
			var userId = "root";
			var password = "root";
			var database = "Edificio";
			return $"server={server};user id={userId};password={password};database={database};treattinyasboolean=true;ConvertZeroDateTime=True;default command timeout=360";
		}
	}
	public BDContext(DbContextOptions<BDContext> options) : base(options)
	{
	}

	public virtual DbSet<Pessoa> Pessoas { get; set; }

}
