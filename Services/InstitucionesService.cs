using Zismed_Apis.Data;

public class InstitucionesService
{
    private readonly ApplicationDbContext _Db;
    public InstitucionesService(ApplicationDbContext db) => _Db = db;

    public List<int> GetInstituciones(bool esClinica, int institucionID = 0)
    {
        if (esClinica)
            return new List<int> { institucionID };
        return _Db.Instituciones
            .Where(l => !l.Anulado && (l.Clinica == false || l.Clinica == null))
            .Select(l => l.InstitucionId)
            .ToList();
    }
}