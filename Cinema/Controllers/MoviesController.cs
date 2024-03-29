﻿using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Cinema.Services;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesService _moviesService;

        public MoviesController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        public IActionResult Movies()
        {
            var movies = _moviesService.GetAllMovies();

            return View("MoviesPage", movies);
        }
    }
}
