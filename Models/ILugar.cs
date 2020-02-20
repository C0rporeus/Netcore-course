namespace NetCore_Estudio.Models
{
    public interface ILugar
    {
        public string Direccion { get; set; }

        void LimpiarLugar();
    }
}