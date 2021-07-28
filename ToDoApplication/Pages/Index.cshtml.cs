using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApplication.Data;

namespace ToDoApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


               public void OnGet()
        {

            List<ToDoItem> ls = new List<ToDoItem>() {
                new ToDoItem(){ ID= "1", Description="Bill"},
                new ToDoItem(){ ID= "2", Description="hohn"},
            };

           
        }
    }
}
