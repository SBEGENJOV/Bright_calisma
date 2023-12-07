using calismaORMData.Repository.IRepository;
using calismaORMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMData.Repository
{
    public class UrunlerRepository : Repository<Urunler>, IUrunlerRepository
    {
        private ApplicationDbContext _context;
        public UrunlerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
