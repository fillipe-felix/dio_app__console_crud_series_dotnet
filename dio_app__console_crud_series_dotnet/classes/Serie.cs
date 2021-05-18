using dio_app__console_crud_series_dotnet.Enum;

namespace dio_app__console_crud_series_dotnet.classes
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Series(Genero genero, string titulo, string descricao, int ano)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public override string ToString()
        {
            return $"Genero: {Genero}, Titulo: {Titulo}, Descricao: {Descricao}, Ano: {Ano}";
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}