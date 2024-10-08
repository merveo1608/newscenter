﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.ENTITIES.Models;

namespace NewsCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    public class ContactController : Controller
    {
        readonly IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }
        public IActionResult Index()
        {
            ViewBag.activeMenu = "Contact";
            return View(_contactManager.GetAll());
        }
        public async Task<IActionResult> DetailContact(int id)
        {
            return View(await _contactManager.FindAsync(id));
        }
        public async Task<IActionResult> DeleteContact(int id)
        {
            _contactManager.Delete(await _contactManager.FindAsync(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DestroyContact(int id)
        {
            TempData["Message"] = _contactManager.Destroy(await _contactManager.FindAsync(id));
            return RedirectToAction("Index");
        }
    }
}
