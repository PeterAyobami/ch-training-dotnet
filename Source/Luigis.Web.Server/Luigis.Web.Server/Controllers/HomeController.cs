using Luigis.Web.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Luigis.Web.Server
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;

            _context = context;
        }

        /// <summary>
        /// This action method loads the website's homepage
        /// </summary>
        /// <returns></returns>
        public IActionResult Home()
        {
            return View();
        }

        /// <summary>
        /// This action method load the website's about page
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            return View();
        }

        /// <summary>
        /// This action method load the website's blog page
        /// </summary>
        /// <returns></returns>
        public IActionResult Blog()
        {
            return View();
        }

        /// <summary>
        /// This action method load the website's services page
        /// </summary>
        /// <returns></returns>
        public IActionResult Services()
        {
            return View();
        }

        /// <summary>
        /// This action method load the website's contact page
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            var model = new MessageViewModel();

            return View(model);
        }

        /// <summary>
        /// Add a message from the contact page
        /// </summary>
        /// <returns></returns>
        public IActionResult AddMessage([FromForm] MessageViewModel model)
        {
            try
            {
                _context.Messages.Add(new MessagesDataModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.Name,
                    Email = model.Email,
                    Subject = model.Subject,
                    Message = model.Message
                });

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return Content($"There's an error: {ex.Message}");
            }

            return Content("Message added successfully");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
