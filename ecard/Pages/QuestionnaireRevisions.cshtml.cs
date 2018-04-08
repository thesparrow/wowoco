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
	public class QuestionnaireRevisionsModel : PageModel
	{

		[BindProperty]
		public Favorites _myFavorites { get; set; }
		private DbBridge _myDbBridge { get; set; }
		private IConfiguration _myConfiguration { get; set; }
		public QuestionnaireRevisionsModel(DbBridge DbBridge, IConfiguration Configuration)
		{
			_myDbBridge = DbBridge;
			_myConfiguration = Configuration;

		}

		public IActionResult OnGet(int id = 0)
		{
			if (id > 0)
			{
				_myFavorites = _myDbBridge.Favorites.Find(id);
				return Page();
			}
			else
			{
				return RedirectToPage("Questionnaire");
			}
		}


		public string Message { get; set; }
		public IActionResult OnPost()
		{


			{
				{
					try
					{
						// DB Related Customized values added with each record
						_myFavorites.created = DateTime.Now.ToString();
						_myFavorites.created_ip = this.HttpContext.Connection.RemoteIpAddress.ToString();


						//Clean Data before insertion 
						_myFavorites.sendername = _myFavorites.sendername.ToLowerInvariant();
						_myFavorites.senderemail = _myFavorites.senderemail.ToLowerInvariant();
						_myFavorites.movie = _myFavorites.movie.ToLowerInvariant();

						// DB-RELATED: UPDATE RECORD ON THE DATABASE 
						_myDbBridge.Favorites.Update(_myFavorites);
						_myDbBridge.SaveChanges();

						//REDIRECT to the page with a new operator (name/value pair)
						return RedirectToPage("QuestionnaireReview", new { id = _myFavorites.ID });
					}

					catch
					{

					}
				}
			}

			return Page();

		}

		/**
		 * reCAPTHCA SERVER SIDE VALIDATION 
		 * 
		 *      Create an HttpClient and store the the secret/response pair
		 *      Await for the sever to return a json obect 
		 * */
		private async Task<bool> isValid()
		{
			var response = this.HttpContext.Request.Form["g-recaptcha-response"];
			if (string.IsNullOrEmpty(response))
				return false;

			try
			{
				using (var client = new HttpClient())
				{
					var values = new Dictionary<string, string>();
					//values.Add("secret", "SECRET KEY");
					values.Add("secret", _myConfiguration["ReCaptcha:PrivateKey"]);

					values.Add("response", response);
					//values.Add("remoteip", this.HttpContext.Connection.RemoteIpAddress.ToString()); 

					var query = new FormUrlEncodedContent(values);

					var post = client.PostAsync("https://www.google.com/recaptcha/api/siteverify", query);

					var json = await post.Result.Content.ReadAsStringAsync();

					if (json == null)
						return false;

					var results = JsonConvert.DeserializeObject<dynamic>(json);

					return results.success;
				}

			}
			catch { }

			return false;
		}

	}
}