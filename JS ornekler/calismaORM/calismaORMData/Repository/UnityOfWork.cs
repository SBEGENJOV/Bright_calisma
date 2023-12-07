using calismaORMData.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calismaORMData.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnityOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IKategoriRepository Kategori => new KategoriRepository(_context);

        public IUrunlerRepository Urunler => new UrunlerRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
