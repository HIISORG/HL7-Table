using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0004 - Patient class.
  /// </summary>
  public enum PatientClass {
    None,
    /// <summary>Emergencey</summary>
    [Display(Name = "Emergencey")]
    E,
    /// <summary>Inpatient</summary>
    [Display(Name = "Inpatient")]
    I,
    /// <summary>Outpatient</summary>
    [Display(Name = "Outpatient")]
    O,
    /// <summary>Preadmit</summary>
    [Display(Name = "Preadmit")]
    P,
    /// <summary>Recurring patient</summary>
    [Display(Name = "Recurring patient")]
    R,
    /// <summary>Obstetrics</summary>
    [Display(Name = "Obstetrics")]
    B,
    /// <summary>Commercial Account</summary>
    [Display(Name = "Commercial Account")]
    C,
    /// <summary>Not Applicable</summary>
    [Display(Name = "Not Applicable")]
    N,
    /// <summary>Unknown</summary>
    [Display(Name = "Unknown")]
    U
  }
}