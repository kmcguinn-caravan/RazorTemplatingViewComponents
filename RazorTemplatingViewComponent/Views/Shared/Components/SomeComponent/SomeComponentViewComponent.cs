using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorTemplatingViewComponent.Views.Shared.Components.SomeComponent
{
    public class SomeComponentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new SomeModel
            {
                SomeProperty = "Some Value"
            };
            return View(model);
        }
    }
}
