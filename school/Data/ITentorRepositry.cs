using System.Collections.Generic;
using System.Threading.Tasks;

namespace school.Data {
    public interface ITentorRepositry {
        Task<IEnumerable<Tentor>> GetTentor();
        Task<Tentor> GetTenta();
    }
}
