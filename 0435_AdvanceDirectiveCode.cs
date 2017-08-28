// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0435: Advance Directive Code
	/// </summary>
	public enum AdvanceDirectiveCode {
		/// <summary>
		/// Do not resuscitate
		/// </summary>
    [Display(Name = "Do not resuscitate")]
		DNR,
		/// <summary>
		/// No directive
		/// </summary>
    [Display(Name = "No directive")]
		N
  }
}
