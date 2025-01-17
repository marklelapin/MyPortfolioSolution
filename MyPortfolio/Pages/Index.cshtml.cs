﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyClassLibrary.Interfaces;
using MyPortfolio.Pages.Models;

namespace MyPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IEmailClient _emailClient;

        [BindProperty]
        public Contact Contact { get; set; } = new Contact();


        public void OnPost()
        {

        }

        public IndexModel(ILogger<IndexModel> logger, IEmailClient emailClient)
        {
            _logger = logger;
            _emailClient = emailClient;
        }


        public PartialViewResult OnGetPartialContent(string viewName)
        {
            var output = Partial(viewName);
            return output;
        }

        //TODO-Create ContactScripts (with partial view in Sections folder) and add replace post below to improve reusuablility.

        public async Task<ContentResult> OnPostSendMessage()
        {
            var sendSuccess = await _emailClient.SendAsync($"{Contact.Email}", "default", $"Portfolio Enquiry from {Contact.Name}", $"{Contact.Message}");
            string result;

            result = (sendSuccess == true) ? "Success" : "Failure";

            return Content(result);

        }

    }
}