// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0161: Allow Substitution
	/// </summary>
	public enum AllowSubstitution {
		/// <summary>
		/// Allow generic substitutions.
		/// </summary>
		[Display(Name = "Allow generic substitutions.")]
    G,
		/// <summary>
		/// Substitutions are NOT authorized. (This is the default - null.)
		/// </summary>
		[Display(Name = "Substitutions are NOT authorized. (This is the default - null.)")]
    N,
		/// <summary>
		/// Allow therapeutic substitutions
		/// </summary>
		[Display(Name = "Allow therapeutic substitutions")]
    T
  }
}
