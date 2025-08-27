namespace Zismed_Apis.Models.Dto
{
    public class ConsultaAmbulatoriaDto
    {
        public int ConsultaId { get; set; }
        public DateTime Fecha { get; set; }
        public string? Evolucion { get; set; }
        public int PacienteId { get; set; }
        public int ObraSocialId { get; set; }
        public string? NombreObraSocial { get; set; }
        public List<DiagnosticosConsultasDto>? Diagnosticos { get; set; }
    }
}
