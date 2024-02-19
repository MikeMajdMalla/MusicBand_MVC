using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicBand.Models;
using Newtonsoft.Json;

namespace MusicBand.Controllers
{

    public class CountryController : Controller
    {
        Country country = new Country();
        List<Country> countryList = new List<Country>();

        // GET: Members
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5078/api/Countries"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    countryList = JsonConvert.DeserializeObject<List<Country>>(apiResponse);
                }

            }

            return View(countryList);
        }


    
    }
    }
