// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0128: Allergy Severity
	/// </summary>
	public enum AllergySeverity {
    /// <summary>
    /// Mild
    /// </summary>
    [Display(Name = "Mild")]
    MI,
    /// <summary>
    /// Moderate
    /// </summary>
    [Display(Name = "Moderate")]
    MO,
    /// <summary>
    /// Severe
    /// </summary>
    [Display(Name = "Severe")]
    SV,
    /// <summary>
    /// Unknown
    /// </summary>
    [Display(Name = "Unknown")]
    U
  }
}
