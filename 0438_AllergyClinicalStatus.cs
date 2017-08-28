// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0438: Allergy Clinical Status
	/// </summary>
	public enum AllergyClinicalStatus {
    /// <summary>
    /// Confirmed or verified
    /// </summary>
    [Display(Name = "Confirmed or verified")]
    C,
    /// <summary>
    /// Doubt raised
    /// </summary>
    [Display(Name = "Doubt raised")]
    D,
    /// <summary>
    /// Erroneous
    /// </summary>
    [Display(Name = "Erroneous")]
    E,
    /// <summary>
    /// Confirmed but inactive
    /// </summary>
    [Display(Name = "Confirmed but inactive")]
    I,
    /// <summary>
    /// Pending
    /// </summary>
    [Display(Name = "Pending")]
    P,
    /// <summary>
    /// Suspect
    /// </summary>
    [Display(Name = "Suspect")]
    S,
    /// <summary>
    /// Unconfirmed
    /// </summary>
    [Display(Name = "Unconfirmed")]
    U
  }
}
