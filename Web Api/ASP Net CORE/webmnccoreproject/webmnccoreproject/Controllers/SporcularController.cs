using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using webmnccoreproject.Models;

namespace webmnccoreproject.Controllers
{
    public class SporcularController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:44361/api/Sporcular").Result;
            List<Sporcular> sporculars;

            sporculars = JsonConvert.DeserializeObject<List<Sporcular>>(response.Content.ReadAsStringAsync().Result);
            return View(sporculars);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Sporcular());
        }
        [HttpPost]
        public IActionResult Create(Sporcular sporcular)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(sporcular), System.Text.Encoding.UTF8, "application/json");//create sayfasına girdigimiz verileri json formatına dönüştürdü.

            var respone = client.PostAsync("https://localhost:44361/api/Sporcular", content).Result;//url içeriside post işlemlerini gerçekleştirdi content ile aslında json formatın adönüşmüş verilerim gitmiş oldu.

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync($"https://localhost:44361/api/Sporcular/{id}").Result;

            var sporculars = JsonConvert.DeserializeObject<Sporcular>(response.Content.ReadAsStringAsync().Result);
            return View(sporculars);
        }

        [HttpPost]
        public IActionResult Edit(Sporcular sporcular)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(sporcular), System.Text.Encoding.UTF8, "application/json");

            var respone = client.PutAsync($"https://localhost:44361/api/Sporcular/{sporcular.SporcuID}", content).Result;

            return RedirectToAction ("Index");
        }

        public IActionResult Delete(int id)
        {
            HttpClient client = new HttpClient();
            var response=client.DeleteAsync($"https://localhost:44361/api/Sporcular/{id}").Result;

            return RedirectToAction("Index");
        }
    }
}
