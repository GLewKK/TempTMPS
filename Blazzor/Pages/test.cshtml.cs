using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blazzor.Pages
{
    public class testModel : PageModel
    {
        public void OnGet()
        {
            
        }
        public int Something { get; set; }
    }
}