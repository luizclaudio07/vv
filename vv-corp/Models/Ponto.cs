using vv_corp.Enums;

namespace vv_corp.Models
{
    public class Ponto
    {
        public long Codigo { get; set; }

        public string Nome { get; set; }

        public TipoPonto Tipo { get; set; }

        public string Pesquisador { get; set; }

        public TipoProtecao NivelProtecao { get; set; }

        public string Endereco { get; set; }

        public string Descricao { get; set; }

        public string Reformas { get; set; }

        public TipoEstilo Estilo { get; set; }

        public TipoSubEstilo SubEstilo { get; set; }

        public string EpocaConstrucao { get; set; }

        public string UsoOriginal { get; set; }

        public string UsoAtual { get; set; }

        public string ProprietarioOriginal { get; set; }

        public string ProprietarioAtual { get; set; }

        public string Arquiteto { get; set; }

        public string Construtor { get; set; }

        public Coordenadas Coordenadas { get; set; }

        public string Fontes { get; set; }
    }
}
