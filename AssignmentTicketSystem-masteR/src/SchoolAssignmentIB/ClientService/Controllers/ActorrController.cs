using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClientService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientService.Controllers
{
    public class ActorrController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<ClientActor> actorList;
            HttpResponseMessage response = ClientHelper.ClientApi.GetAsync("Actor").Result;
            actorList = response.Content.ReadAsAsync<IEnumerable<ClientActor>>().Result;
            return View(actorList);
        }
        
        public IActionResult Hire(int id = 0)
        {
            if (id == 0)
                return View(new ClientActor());
            else
            {
                HttpResponseMessage response = ClientHelper.ClientApi.GetAsync("Actor/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<ClientActor>().Result);
            }
        }
    }
}