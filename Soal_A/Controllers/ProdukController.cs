using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Soal_A.Models;

namespace Soal_A.Controllers
{
    public class ProdukController : Controller
    {
        ProdukAccessDataLayer ProdukDataAccessLayer = null;

        public ProdukController()
        {
            ProdukDataAccessLayer = new ProdukAccessDataLayer();
        }

        // GET: Produk
        public ActionResult Index()
        {
            IEnumerable<Produk> Produks = ProdukDataAccessLayer.GetAllProduk();
            return View(Produks);
        }

        // GET: Produk/Details/5
        public ActionResult Details(int id)
        {
            Produk Produk = ProdukDataAccessLayer.GetProdukData(id);
            return View(Produk);

        }

        // GET: Produk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produk/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produk Produk)
        {
            try
            {
                // TODO: Add insert logic here
                ProdukDataAccessLayer.AddProduk(Produk);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Produk/Update/5
        public ActionResult Update(int id)
        {
            Produk Produk = ProdukDataAccessLayer.GetProdukData(id);
            return View(Produk);
        }

        // POST: Produk/Update/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Produk Produk)
        {
            try
            {
                // TODO: Add update logic here
                ProdukDataAccessLayer.UpdateProduk(Produk);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Produk/Delete/5
        public ActionResult Delete(int id)
        {
            Produk Produk = ProdukDataAccessLayer.GetProdukData(id);
            return View(Produk);
        }

        // POST: Produk/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Produk Produk)
        {
            try
            {
                // TODO: Add delete logic here
                ProdukDataAccessLayer.DeleteProduk(Produk.id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
