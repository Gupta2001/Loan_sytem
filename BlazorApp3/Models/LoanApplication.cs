

namespace BlazorApp3.Models
{
	[Serializable]
	public class LoanApplication
	{
		public string FullName { get; set; }

		public int Id { get; set; }	
		public string FatherName { get; set; } 
		public string Email { get; set; }
        public string BranchCode { get; set; }

		public string PhoneNo { get; set; }

		public string AadharNo { get; set; }

		public int LoanAmount { get; set; }

		public string Address { get; set;}

		public string City { get; set;}

		public string Pincode { get; set;}

    }
}
