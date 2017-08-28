using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// Optionality.
	/// </summary>
	public enum Optionality {
		None,
		/// <summary> Required </summary>
		[Display(Name = "Required")]
		R,
		/// <summary> Optional </summary>
		[Display(Name = "Optional")]
		O,
		/// <summary> Conditional on the trigger event or on some other field(s) </summary>
		[Display(Name = "Conditional on the trigger event or on some other field(s)")]
		C,
		/// <summary> Not used with this trigger event </summary>
		[Display(Name = "Not used with this trigger event")]
		X,
		/// <summary> Left in fro backward compability with previous version of HL7 </summary>
		[Display(Name = "Left in fro backward compability with previous version of HL7")]
		B
	}
}