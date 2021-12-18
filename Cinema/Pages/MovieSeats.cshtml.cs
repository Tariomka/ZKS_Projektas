using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Cinema.Pages
{
    public class MovieSeatsModel : PageModel
    {
        private readonly ILogger<MovieSeatsModel> _logger;

        public MovieSeatsModel(ILogger<MovieSeatsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
