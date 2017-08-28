using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0155 - Accept/Application Acknowledgment Conditions
  /// </summary>
  public enum AcknowledgementCondition {
    None,
    /// <summary> Always </summary>
    [Display(Name = "Always")]
    AL,
    /// <summary> Error/reject conditions only </summary>
    [Display(Name = "Error/reject conditions only")]
    ER,
    /// <summary> Never </summary>
    [Display(Name = "Never")]
    NE,
    /// <summary> Successful completion only </summary>
    [Display(Name = "Successful completion only")]
    SU
  }
}