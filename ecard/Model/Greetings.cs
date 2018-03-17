﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
	public class Greetings
	{
		[Key]
		public int ID { get; set; }

		[DisplayName("Your Friend's Name")]
		[Display(Prompt = "Your Friend's Name")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string friendname { get; set; }

		[DisplayName("Your Friend's Email")]
		[Display(Prompt = "Your Friend's Email")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string friendemail { get; set; }

		[DisplayName("Email Subject")]
		[Display(Prompt = "Email Subject")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string subject { get; set; }

		[DisplayName("Your Custom Message")]
		[Display(Prompt = "Your Custom Message")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string message { get; set; }

		[DisplayName("Your Name")]
		[Display(Prompt = "Your Name")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string sendername { get; set; }

		[DisplayName("Your Email")]
		[Display(Prompt = "Your Email")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string senderemail { get; set; }

		[DisplayName("What is your favorite movie?")]
		[Display(Prompt = "Movie Title")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string movie { get; set; }

		[DisplayName("What El Segundo Restaurants you are interested in visiting (list one or more)?")]
		[Display(Prompt = "Rock & Brews, Sausal, etc.")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		[Required(ErrorMessage = "Required")]
		public string restaurant { get; set; }

		//[DisplayName("Select one or more of the El Segundo Restaurants you are interested in visiting")]
		//[Value("Rock & Brews")]
		//[Required(ErrorMessage = "Required")]
		//public bool rocknbrew { get; set; }

		[DisplayName("What is your favorite holiday?")]
		[Display(Prompt = "Thanksgiving, National Donut Day, etc.")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		[Required(ErrorMessage = "Required")]
		public string holiday { get; set; }

		[DisplayName("What is your favorite color?")]
		[Display(Prompt = "Color")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		[Required(ErrorMessage = "Required")]
		public string color { get; set; }

		[DisplayName("What is your birthday?")]
		[Display(Prompt = "Date / Month")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		[Required(ErrorMessage = "Required")]
		public string birthday { get; set; }


		public string created { get; set; }

		public string created_ip { get; set; }

	}
}
