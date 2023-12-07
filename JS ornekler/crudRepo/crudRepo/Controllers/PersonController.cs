using crudRepo.Models;
using crudRepo.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace crudRepo.Controllers
{
    public class PersonController : Controller
    {
        public readonly IPerson personRepo;
        public PersonController(IPerson personRepo)
        {
            this.personRepo = personRepo;
        }
        public async Task<IActionResult> GetPersonList()
        {
            var data = await personRepo.GetPerson();
            return View(data);
        }
        public async Task<IActionResult> AddPerson()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPerson(Person person)
        {
            await personRepo.AddPerson(person);
            if (person.PersonID == 0)
            {
                TempData["personError"] = "Kayıt Başarısız";
               
            }
            else
            {
             TempData["personSucces"] = "Kayıt Başarılı";
            }
            return RedirectToAction("GetPersonList");
        }
        public async Task<IActionResult> Edit (int id)
        {
            Person person = new Person();
            try
            {
                if (id==0)
                {
                    return BadRequest();
                }
                else
                {
                    person=await personRepo.GetPersonById(id);
                    if (person==null)
                    {
                        return NotFound();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(person);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            bool status= await personRepo.UpdateRecord(person);
            if (person.PersonID==0)
            {
                TempData["personError"] = "Güncelleme gerçekleşemedi";
            }
            else
            {
                TempData["personSucces"] = "Güncelleme gerçekleşdi";
            }
            return RedirectToAction("GetPersonList");
        }

        //public async Task<IActionResult> Delete(Person person)
        //{
        //    bool status = await personRepo.RecordDelete(person.PersonID);
        //    if (person.PersonID == 0)
        //    {
        //        TempData["personError"] = "Güncelleme gerçekleşemedi";
        //    }
        //    else
        //    {
        //        TempData["personSucces"] = "Güncelleme gerçekleşdi";
        //    }
        //    return RedirectToAction("GetPersonList");
        //}
    }
}
