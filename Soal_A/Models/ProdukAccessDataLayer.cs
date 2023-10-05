using Soal_A.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Soal_A.Models
{
    public class ProdukAccessDataLayer
    {
        string connectionString = ConnectionString.CName;


        public IEnumerable<Produk> GetAllProduk()
        {
            List<Produk> lstProduk = new List<Produk>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GelAllProduk", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Produk _Produk = new Produk();

                    _Produk.id = Convert.ToInt32(rdr["id"]);
                    _Produk.nama_barang = rdr["nama_barang"].ToString();
                    _Produk.kode_barang = rdr["kode_barang"].ToString();
                    _Produk.jumlah_barang = rdr["jumlah_barang"].ToString();
                    _Produk.tanggal = Convert.ToDateTime(rdr["tanggal"]);

                    lstProduk.Add(_Produk);
                }
                con.Close();
            }
            return lstProduk;
        }


        public void AddProduk(Produk Produk)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddProduk", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nama_barang", Produk.nama_barang);
                cmd.Parameters.AddWithValue("@kode_barang", Produk.kode_barang);
                cmd.Parameters.AddWithValue("@jumlah_barang", Produk.jumlah_barang);
                cmd.Parameters.AddWithValue("@tanggal", Produk.tanggal);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateProduk(Produk Produk)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateProduk", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", Produk.id);
                cmd.Parameters.AddWithValue("@nama_barang", Produk.nama_barang);
                cmd.Parameters.AddWithValue("@kode_barang", Produk.kode_barang);
                cmd.Parameters.AddWithValue("@jumlah_barang", Produk.jumlah_barang);
                cmd.Parameters.AddWithValue("@tanggal", Produk.tanggal);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Produk GetProdukData(int? id)
        {
            Produk Produk = new Produk();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchProduk", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);


                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Produk.id = Convert.ToInt32(rdr["id"]);
                    Produk.nama_barang = rdr["nama_barang"].ToString();
                    Produk.kode_barang = rdr["kode_barang"].ToString();
                    Produk.jumlah_barang = rdr["jumlah_barang"].ToString();
                    Produk.tanggal = Convert.ToDateTime(rdr["tanggal"]);
                }
            }
            return Produk;
        }

        public void DeleteProduk(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteProduk", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

