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
    public class LocationController : BaseController<Location, LocationRepository>
    {
        public LocationController(LocationRepository locationRepository) : base(locationRepository)
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }


        /*public async Task<IActionResult> Index()
        {
            var location = await Get();
            return View(location.AsEnumerable());
        }*/

        //CREATE
        /*public async Task<IActionResult> Create()
        {
            var country = await countryRepository.GetAll();
            ViewBag.Country = new SelectList(country.AsEnumerable(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Location location)
        {
            var result = Post(location);
            if (result == HttpStatusCode.OK)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }


        //EDIT
        public async Task<IActionResult> Edit(int id)
        {
            var country = await countryRepository.GetAll();
            ViewBag.Country = new SelectList(country.AsEnumerable(), "Id", "Name");
            var result = await Get(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Location location)
        {
            var result = Put(id, location);
            if (result == HttpStatusCode.OK)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }


        //DELETE
        public IActionResult Delete(int id)
        {
            var result = Get(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Location location)
        {
            var result = DeleteEntity(location);
            if (result == HttpStatusCode.OK)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }*/
    }
}
