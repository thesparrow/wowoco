using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ecard.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ecard.Pages
{
	public class QuestionnaireReviewModel : PageModel
	{

		[BindProperty]
		public Favorites _myFavorites { get; set; }
		private DbBridge _myDbBridge { get; set; }
		private IConfiguration _myConfiguration { get; set; }
		public QuestionnaireReviewModel(DbBridge DbBridge, IConfiguration Configuration)
		{
			_myDbBridge = DbBridge;
			_myConfiguration = Configuration;

		}

		public void OnGet(int ID = 0)
		{
			if (ID > 0)
			{
				_myFavorites = _myDbBridge.Favorites.Find(ID);
			}
		}


		public IActionResult OnPost(int id = 0)
		{
			if (id > 0)
			{
				_myFavorites = _myDbBridge.Favorites.Find(id);

				try
				{
					return RedirectToPage("Questionnaire", new { id = _myFavorites.ID });
				}

				catch (Exception ex)
				{
					Console.WriteLine(ex);
					return RedirectToPage("Questionnaire");
				}
			}

			return Page();

		}

	}
}