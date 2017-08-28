using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0002: Marrital status.
  /// </summary>
  public enum MarritalStatus {
    None,
    [Display(Name = "Separated")]
    A,
    [Display(Name = "Divorced")]
    D,
    [Display(Name = "Married")]
    M,
    [Display(Name = "Single")]
    S,
    [Display(Name = "Widowed")]
    W,
    [Display(Name = "Common Law")]
    C,
    [Display(Name = "Living Together")]
    G,
    [Display(Name = "Domestic Partner")]
    P,
    [Display(Name = "Registered Domestic Partner")]
    R,
    [Display(Name = "legally Separated")]
    E,
    [Display(Name = "Annulled")]
    N,
    [Display(Name = "Interlocutory")]
    I,
    [Display(Name = "Unmarried")]
    B,
    [Display(Name = "Unknown")]
    U,
    [Display(Name = "Other")]
    O,
    [Display(Name = "Unreported")]
    T
  }
}