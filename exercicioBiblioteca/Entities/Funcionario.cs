using exercicioBiblioteca.Entities;

public class Funcionario : Pessoa
{
	public Funcionario(string nome, string cpf) : base(nome, cpf){}

    public override void ObterIdentificacao()
    {
        throw new NotImplementedException();
    }
}