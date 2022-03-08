using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
      private List<Serie> listSerie = new List<Serie>();
      public void Atualiza (int id, Serie objeto)
      {
          listaSerie[id]= objeto;
      }
      
      public void Exclui(int id)
      {
          listaSerie[Id].Excluir();
      }

      public void Insere(Serie Objeto)
      {
          listaSerie.Add(objeto);
      }

      public List<Serie> Lista()
      {
          return listaSerie;
      }

      public int ProximoId()
      {
          return listaSerie.Count;
      }

      public Serie RetornaPorId(int id)
      {
          return listaSerie[id];
      }
    }
}