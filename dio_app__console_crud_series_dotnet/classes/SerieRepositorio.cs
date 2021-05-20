using System.Collections.Generic;
using dio_app__console_crud_series_dotnet.interfaces;

namespace dio_app__console_crud_series_dotnet.classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listSerie = new List<Serie>();
        public List<Serie> Lista()
        {
            return listSerie;
        }

        public Serie RetornaPorId(int id)
        {
            return listSerie[id];
        }

        public void Insere(Serie entiada)
        {
            listSerie.Add(entiada);
        }

        public void Excluir(int id)
        {
            listSerie[id].Excluir();
        }

        public void Atualizar(int id, Serie entidade)
        {
            listSerie[id] = entidade;
        }

        public int ProximoId()
        {
            return listSerie.Count;
        }
    }
}