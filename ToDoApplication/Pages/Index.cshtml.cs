using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApplication.Data;
using ToDoApplication.Data.Context;

namespace ToDoApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ToDoContext _toDoContext;

        public IndexModel(ILogger<IndexModel> logger, ToDoContext context)
        {
            _logger = logger;
            _toDoContext = context;
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
