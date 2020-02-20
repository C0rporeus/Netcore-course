using System;

namespace NetCore_Estudio.Models
{
    // herencia para las demas entidades / la clase es solo idealizada, no se pueden crear objetos con ella, solo ser heredada por otros objetos
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }
        // al incluir este atributo se puede depurar mas facilmente la informacion viendo de forma explcita los datos que se requieren
        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}