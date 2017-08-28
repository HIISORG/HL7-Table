// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0616: Address Expiration Reason
  /// </summary>
	public enum AddressExpirationReason {
    /// <summary>
    /// Corrected
    /// </summary>
    [Display(Name = "Corrected")]
    C,
    /// <summary>
    /// Added in error
    /// </summary>
    [Display(Name = "Added in error")]
    E,
    /// <summary>
    /// Movved
    /// </summary>
    [Display(Name = "Moved")]
    M,
    /// <summary>
    /// On request
    /// </summary>
    [Display(Name = "On request")]
    R
  }
}
