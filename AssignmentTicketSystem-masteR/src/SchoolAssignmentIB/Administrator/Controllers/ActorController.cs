using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Administrator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Administrator.Controllers
{
    public class ActorController : Controller
    {

        public IActionResult Index()
        {
            IEnumerable<AdminActor> actorList;
            HttpResponseMessage response = WebsiteClient.WebApiClient.GetAsync("Actor").Result;
            actorList = response.Content.ReadAsAsync<IEnumerable<AdminActor>>().Result;
            return View(actorList);
        }

        public IActionResult PutOrPost(int id = 0)
        {

            if (id == 0)
                return View(new AdminActor());
            else
            {
                HttpResponseMessage response = WebsiteClient.WebApiClient.GetAsync("Actor/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<AdminActor>().Result);
            }
        }
        [HttpPost]

        public IActionResult PutOrPost(AdminActor actor)
        {
            if (actor.ActorID == 0)
            {
                HttpResponseMessage response = WebsiteClient.WebApiClient.PostAsJsonAsync("Actor", actor).Result;
            }
            else
            {
                HttpResponseMessage response = WebsiteClient.WebApiClient.PutAsJsonAsync("Actor/" + actor.ActorID, actor).Result;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = WebsiteClient.WebApiClient.DeleteAsync("Actor/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}