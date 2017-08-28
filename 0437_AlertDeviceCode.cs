// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0437: Alert Device Code
	/// </summary>
	public enum AlertDeviceCode {
		/// <summary>
		/// Bracelet
		/// </summary>
    [Display(Name = "Bracelet")]
		B,
    /// <summary>
    /// Necklace
    /// </summary>
    [Display(Name = "Necklace")]
    N,
    /// <summary>
    /// Wallet card
    /// </summary>
    [Display(Name = "Wallet card")]
    W
  }
}
