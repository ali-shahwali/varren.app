using System.Collections.Generic;
using System.Threading.Tasks;

namespace school.Data {
    public class TentorRepositry : ITentorRepositry {
        private readonly ApplicationDbContext applicationDbContext;

        public TentorRepositry(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Tentor>> GetTentor() {
            return await applicationDbContext.Tentor.ToListAsync();
        }
    }
}