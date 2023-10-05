using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Soal_A.Models
{
    public class Produk
    {
        public int id { set; get; }
        [Required]
        public string nama_barang { set; get; }
        [Required]
        public string kode_barang { set; get; }
        [Required]
        public string jumlah_barang { set; get; }
        [Required]
        public DateTime tanggal { set; get; }
    }
}
