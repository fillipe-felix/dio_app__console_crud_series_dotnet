using System.Collections.Generic;

namespace dio_app__console_crud_series_dotnet.interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entiada);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}