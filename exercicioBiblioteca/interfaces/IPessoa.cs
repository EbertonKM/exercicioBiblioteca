namespace exercicioBiblioteca.Interfaces;

public interface IPessoa
{
	string Nome { get; set; }
    string CPF { get; set; }
	public abstract	void ObterIdentificação();
}