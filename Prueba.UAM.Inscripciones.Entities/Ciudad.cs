namespace Prueba.UAM.Inscripciones.Entities
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre_Ciudad { get; set; }
        public int? Id_Departamento { get; set; }

        public Departamento Departamento { get; set; }
    }
}
