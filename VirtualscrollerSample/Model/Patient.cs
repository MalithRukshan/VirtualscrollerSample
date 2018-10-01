using System;

namespace VirtualscrollerSample.Model
{
	public class Patient
	{
        public int Oid { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime? FreeCard { get; set; }
        public DateTime? FreeCard2 { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? LastTreatment { get; set; }
    }
}
