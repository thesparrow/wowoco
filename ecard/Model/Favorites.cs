using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecard.Model
{
	public class Favorites
	{
		[Key]
		public int ID { get; set; }

		[DisplayName("Your Name")]
		[Display(Prompt = "First & Last Name")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string sendername { get; set; }

		[DisplayName("Your Email")]
		[Display(Prompt = "email@example.com")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string senderemail { get; set; }

		[DisplayName("What is your favorite movie?")]
		[Display(Prompt = "Enter One Movie Title")]
		[Required(ErrorMessage = "Required")]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
		public string movie { get; set; }

		[DisplayName("What El Segundo Restaurant are you most interested in visiting?")]
		[Required(ErrorMessage = "Required")]
		public string restaurant { get; set; }

		//TEMPORARY VARIABLE FOR CHECKBOX USE ONLY
		[NotMapped]
		public string[] restaurant_array { get; set; }

		[DisplayName("What is your favorite holiday?")]
		[Required(ErrorMessage = "Required")]
		public string holiday { get; set; }

		[DisplayName("What is your favorite color?")]
		public string color { get; set; }

		[DisplayName("What month is your birthday?")]
		[Required(ErrorMessage = "Required")]
		public string birthdaymonth { get; set; }

		[DisplayName("Day?")]
		[Required(ErrorMessage = "Required")]
		public string birthdayday { get; set; }

		public string created { get; set; }

		public string created_ip { get; set; }


	}
}
