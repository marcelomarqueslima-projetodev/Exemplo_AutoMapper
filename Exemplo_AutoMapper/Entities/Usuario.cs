using Exemplo_AutoMapper.Entitiess;

namespace Exemplo_AutoMapper.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Sexo { get; private set; }
        public int Idade { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
