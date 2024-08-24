using exercicioBiblioteca.Entities;

namespace exercicioBiblioteca.Entities;

public class Cliente : Pessoa
{
	public Cliente(string nome, string cpf) : base(nome, cpf){}

    public override void ObterIdentificacao()
    {
        throw new NotImplementedException();
    }
}