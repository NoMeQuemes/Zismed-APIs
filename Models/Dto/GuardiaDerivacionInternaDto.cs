namespace Zismed_Apis.Models.Dto
{
    public class GuardiaDerivacionInternaDto
    {
        public int GuardiaRegistroId { get; set; }
        public int? GuardiaSectorDesdeId { get; set; }
        public int? GuardiaSectorHastaId { get; set; }
        public int? GuardiaCamaId { get; set; }
        public int PrestadorId { get; set; }
        public string? Usuario { get; set; }
    }
}