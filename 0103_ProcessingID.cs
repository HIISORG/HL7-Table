using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0103. Processing ID
  /// </summary>
  public enum ProcessingID {
    None,
    /// <summary> Debugging </summary>
    [Display(Name = "Debugging")]
    D,
    /// <summary> Production </summary>
    [Display(Name = "Production")]
    P,
    /// <summary> Training </summary>
    [Display(Name = "Training")]
    T
  }
}