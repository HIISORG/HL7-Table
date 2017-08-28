using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0204 - Organizational Name Type.
  /// </summary>
  public enum OrganizationalNameType {
    None,
    /// <summary> Alias name. </summary>
    [Display(Name = "Alias name")]
    A,
    /// <summary> Display name. </summary>
    [Display(Name = "Dispaly name")]
    D,
    /// <summary> Legal name. </summary>
    [Display(Name = "Legal name")]
    L,
    /// <summary> Stock exchange listing name. </summary>
    [Display(Name = "Stock exchange listing name")]
    SL
  }
}