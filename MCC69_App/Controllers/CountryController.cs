﻿using API.Models;
using MCC69_App.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MCC69_App.Controllers
{
    [Authorize]
    public class CountryController : BaseController<Country, CountryRepository>
    {
        public CountryController(CountryRepository countryRepository) : base(countryRepository)
        {
            
        }
        
        public IActionResult Index()
        {
            return View();
        }


        /*public async Task<IActionResult> Index()
        {
            var country = await Get();
            return View(country.AsEnumerable());
        }*/

        //CREATE
        /*public async Task<IActionResult> Create()
        {
            var region = await regionRepository.GetAll();
            ViewBag.Region = new SelectList(region.AsEnumerable(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country country)
        {
            var result = Post(country);
            if (result == HttpStatusCode.OK)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }


        //EDIT
        public async Task<IActionResult> Edit(int id)
        {
            var region = await regionRepository.GetAll();
            ViewBag.Region = new SelectList(region.AsEnumerable(), "Id", "Name");
            var result = await Get(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Country country)
        {
            var result = Put(id, country);
            if (result == HttpStatusCode.OK)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        //DELETE
        public IActionResult Delete(int id)
        {
            var result = Get(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Country country)
        {
            var result = DeleteEntity(country);
            if (result == HttpStatusCode.OK)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }*/
    }
}
