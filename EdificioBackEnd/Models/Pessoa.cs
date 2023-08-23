namespace EdificioBackEnd.Models;

[Index(nameof(CPF), IsUnique = true)]
public class Pessoa
{
	[Key]
	public int Id { get; set; }
	public required string Nome { get; set; }
	public required string CPF { get; set; }
}
