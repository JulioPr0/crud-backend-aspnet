using Backend.Models;

namespace Backend.Interface
{
    public interface IJabatan
    {
        Jabatan Save(Jabatan oJabatan);
        Jabatan Update(Jabatan oJabatan);
        List<Jabatan> Gets();
        Jabatan Get(string kodejabatan);
        string Delete(string kodejabatan);
        int GetKodeJabatan();
    }
}
