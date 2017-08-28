// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AdmissionLevelOfCareCode {
    /// <summary>
    /// Acute
    /// </summary>
    [Display(Name = "Acute")]
    AC,
    /// <summary>
    /// Chronic
    /// </summary>
    [Display(Name = "Chronic")]
    CH,
    /// <summary>
    /// Comatose
    /// </summary>
    [Display(Name = "Comatose")]
    CO,
    /// <summary>
    /// Critical
    /// </summary>
    [Display(Name = "Critical")]
    CR,
    /// <summary>
    /// Improved
    /// </summary>
    [Display(Name = "Improved")]
    IM,
    /// <summary>
    /// Moribund
    /// </summary>
    [Display(Name = "Moribund")]
    MO
  }
}
