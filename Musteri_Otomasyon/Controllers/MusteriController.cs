using Bussines.Managers;
using DataAccess.Context;
using DataAccess.Repositories;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using X.PagedList;

namespace Musteri_Otomasyon.Controllers
{
    
    public class MusteriController : Controller
    {
        MusteriManager musterimanager = new MusteriManager(new MusteriRepositories());
        public IActionResult List(int page = 1)
        {
            IPagedList<Musteri> list = musterimanager.GetAll().ToPagedList(page,5);
            return View(list);
        }

        public IActionResult Details(int id) 
        {
            Musteri entity = musterimanager.GetbyId(id);
            return View(entity);
        }
        [HttpPost]
        public void Delete(int id)
        {
            Musteri entity = musterimanager.GetbyId(id);
            musterimanager.Remove(entity);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Musteri musteri)
        {
            Musteri _musteri = musterimanager.GetbyId(musteri.Id);
            if(_musteri == null)
            {
                if(ModelState.IsValid)
                {
                    musterimanager.Add(musteri);
                    return RedirectToAction("List");
                }
                else
                {
                    return View(musteri);
                }
                
            }
           else
            {
                if(ModelState.IsValid)
                {
                    musterimanager.update(musteri);
                    return RedirectToAction("List");
                }
                else
                {
                    return View(musteri);
                }
            }
            
        }

        public IActionResult Update(int id)
        {
            Musteri entity = musterimanager.GetbyId(id);
            return View(entity);
        }
    }
}
