using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornoPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();

    }
}
