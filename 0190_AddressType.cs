using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0190. <para />
	/// Address type used for AD and XAD
	/// </summary>
	public enum AddressType {
		/// <summary> Default empty value. </summary>
		[Display(Name = "Default")]
		None,
		/// <summary> Bad address </summary>
		[Display(Name = "Bad address")]
		BA = 1,
		/// <summary> Birth (nee) (birth address, not otherwise specified) </summary>
		[Display(Name = "Birth (nee) (birth address, not otherwise specified)")]
		N = 2,
		/// <summary> Birth delivery location (address where birth occurred) </summary>
		[Display(Name = "Birth delivery location (address where birth occurred)")]
		BDL = 3,
		/// <summary> Country of Origin </summary>
		[Display(Name = "Country of Origin")]
		F = 4,
		/// <summary> Current or Temporary </summary>
		[Display(Name = "Current or Temporary")]
		C = 5,
		/// <summary> Firm/Business </summary>
		[Display(Name = "Firm/Business")]
		B = 6,
		/// <summary> Home </summary>
		[Display(Name = "Home")]
		H = 6,
		/// <summary> Legal address </summary>
		[Display(Name = "Legal address")]
		L = 7,
		/// <summary> Mailing </summary>
		[Display(Name = "Mailing")]
		M = 8,
		/// <summary> Office </summary>
		[Display(Name = "Office")]
		O = 9,
		/// <summary> Permanent </summary>
		[Display(Name = "Permanent")]
		P = 10,
		/// <summary> Registry home </summary>
		[Display(Name = "Registry home")]
		RH = 11,
		/// <summary> Residence at birth (home address at time of birth) </summary>
		[Display(Name = "Residence at birth (home address at time of birth)")]
		BR = 12
	}
}