using System;
using System.Collections.Generic;
using Series;
 
namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Task objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Excluir(int Id)
        {
            listaSerie.RemoveAt(Id);
        }

        public void Insere(Task entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Serie RetornaPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}