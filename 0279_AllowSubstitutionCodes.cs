// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0279: Allow Substitution Codes
	/// </summary>
	public enum AllowSubstitutionCodes {
		/// <summary>
		/// Contact the Placer Contact Person prior to making any substitutions of this resource
		/// </summary>
		[Display(Name = "Contact the Placer Contact Person prior to making any substitutions of this resource")]
    Confirm,
		/// <summary>
		/// Substitution of this resource is not allowed
		/// </summary>
		[Display(Name = "Substitution of this resource is not allowed")]
    No,
		/// <summary>
		/// Notify the Placer Contact Person, through normal institutional procedures, that a substitution of this resource has been made
		/// </summary>
		[Display(Name = "Notify the Placer Contact Person, through normal institutional procedures, that a substitution of this resource has been made")]
    Notify,
		/// <summary>
		/// Substitution of this resource is allowed
		/// </summary>
		[Display(Name = "Substitution of this resource is allowed")]
    Yes
  }
}
