using dio_app__console_crud_series_dotnet.Enum;

namespace dio_app__console_crud_series_dotnet.classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            return $"Genero: {Genero}, Titulo: {Titulo}, Descricao: {Descricao}, Ano: {Ano}, Excluido: {Excluido}";
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            Excluido = true;
        }
    }
}