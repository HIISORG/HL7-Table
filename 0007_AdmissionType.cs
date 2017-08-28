using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AdmissionType {
    /// <summary>Accident</summary>
    [Display(Name = "Accident")]
    A,
    /// <summary>Emergencey</summary>
    [Display(Name = "Emergency")]
    E,
    /// <summary> Labor and Delivery </summary>
    [Display(Name = "labor and Delivery")]
    L,
    /// <summary> Routine </summary>
    [Display(Name = "Routine")]
    R,
    /// <summary>Newborn (Birth in healthcare facility </summary>
    [Display(Name = "Newborn (birth in healthcare facility)")]
    N,
    /// <summary>Urgent</summary>
    [Display(Name = "Urgent")]
    U,
    /// <summary> Electivev</summary>
    [Display(Name = "Elective")]
    C
  }
}