using calismaORMData.Repository.IRepository;
using calismaORMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMData.Repository
{
    public class KategoriRepository : Repository<Kategori>, IKategoriRepository
    {
        private ApplicationDbContext _context;
        public KategoriRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
