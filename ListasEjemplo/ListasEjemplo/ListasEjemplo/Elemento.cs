using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEjemplo
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class ListaElementos
    {
        public List<Elemento> _elementos { get; set; }
        //constructor
        public ListaElementos()
        {
            _elementos = new List<Elemento>();
            LoadElements();
        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre="Elemento 1",
                Descripcion="Descripción elemento 1"
            });
            
            _elementos.Add(new Elemento
            {
                Nombre = "Elemento 2",
                Descripcion = "Descripción elemento 2"
            });

        }


    }

}
