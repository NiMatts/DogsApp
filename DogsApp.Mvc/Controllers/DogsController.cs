﻿using DogsApp.Mvc.Models;
using DogsApp.Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogsApp.Mvc.Controllers;

public class DogsController : Controller
{
    static DogService dogService = new DogService();
    //4e: annars skapas en ny lista
    public DogsController() { }

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = dogService.GetAllDogs();
        return View(model);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Dog dog)
    {
        dogService.AddDog(dog);

        return RedirectToAction(nameof(Index));
    }

}




