// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AccessRestrictionReasonCode {
    /// <summary>
    /// Diagnosis-related
    /// </summary>
    [Display(Name = "Diagnosis-related")]
    DIA,
    /// <summary>
    /// Employee of this organization
    /// </summary>
    [Display(Name = "Employee of this organization")]
    EMP,
    /// <summary>
    /// Organizational policy or requirement
    /// </summary>
    [Display(Name = "Organizational policy or requirement")]
    ORG,
    /// <summary>
    /// Patient Request
    /// </summary>
    [Display(Name = "Patient Request")]
    PAT,
    /// <summary>
    /// Physician Request
    /// </summary>
    [Display(Name = "Physician Request")]
    PHY,
    /// <summary>
    /// Regulatory Requirement
    /// </summary>
    [Display(Name = "Regulatory Requirement")]
    REG,
    /// <summary>
    /// Very important person or celebrity
    /// </summary>
    [Display(Name = "Very important person or celebrity")]
    VIP
  }
}