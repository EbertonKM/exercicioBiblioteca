using exercicioBiblioteca.Interfaces;

namespace exercicioBiblioteca.Entities;

public abstract class Pessoa : IPessoa
{
	public string Nome { get; set; }
	public string CPF { get; set; }
	
	public Pessoa(string nome, string cpf)
	{
		Nome = nome;
		CPF = cpf;
	}
	
	public abstract	void ObterIdentificação();
}