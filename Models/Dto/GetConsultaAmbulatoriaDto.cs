namespace Zismed_Apis.Models.Dto
{
    public class GetConsultaAmbulatoriaDto
    {
        public int ConsultaId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Evolucion { get; set; }
        public int PacienteId { get; set; }
        public int ObraSocialId { get; set; }
        public string? NombreObraSocial { get; set; }
        public string? PacienteNombre { get; set; }
        public int? TurnoID { get; set; }
        public int? GuardiaRegistroID { get; set; }
        public int? InterconsultaID { get; set; }
        public int? CamaId { get; set; }
        public List<DiagnosticosConsultasDto>? Diagnosticos { get; set; }
    }
}
