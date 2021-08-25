using Exemplo_AutoMapper.Entitiess;

namespace Exemplo_AutoMapper.Entities
{
    public class Endereco : Entity
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
