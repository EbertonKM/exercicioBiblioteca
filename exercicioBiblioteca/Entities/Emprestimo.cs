using exercicioBiblioteca.Entities;

public class Emprestimo
{
	public Livro Livro { get; set; }
	public Cliente Cliente { get; set; }
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	
	public Emprestimo(Livro livro, Cliente cliente, DateTime dataEmprestimo, DateTime dataDevolucao)
	{
		this.Livro = livro;
		this.Cliente = cliente;
		this.DataEmprestimo = dataEmprestimo;
		this.DataDevolucao = dataDevolucao;
	}
}