﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriName { get; set; }
        public string KategoriDescription { get; set; }
        public bool KategoriStatus { get; set; }
        public List<Blog> Blogs  { get; set; }
    }
}
