using System;

namespace NetCore_Estudio.Models
{
    // herencia para las demas entidades / la clase es solo idealizada, no se pueden crear objetos con ella, solo ser heredada por otros objetos
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        public virtual string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}