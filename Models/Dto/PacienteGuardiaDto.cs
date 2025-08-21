namespace Zismed_Apis.Models.Dto
{
    public class PacienteGuardiaDto
    {
        //public int GuardiaRegistroID { get; set; }
        //public string PacienteNombre { get; set; } = string.Empty;
        //public string FechaIngreso { get; set; } = string.Empty;
        //public string PrestadorRecibe { get; set; } = string.Empty;
        //public string Lugar { get; set; } = string.Empty;
        //public int? TipoCuracionID { get; set; }

        public int GuardiaRegistroID { get; set; }
        public string PacienteNombre { get; set; }
        public string FechaIngreso { get; set; }
        public string PrestadorRecibe { get; set; }
        public string Lugar { get; set; }
        public int? TipoCuracionID { get; set; }
        //public bool Atendido { get; set; }
        //public int PacienteID { get; set; }
        public int GuardiaSectorID { get; set; }
        public string SectorNombre { get; set; }
        public string SectorAnterior { get; set; }
    }
}
