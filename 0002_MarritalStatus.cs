using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0002: Marrital status.
  /// </summary>
  public enum MarritalStatus {
    [Display(Name = "")]
    None,
    [Display(Name = "Separated", ShortName = "A")]
    A,
    [Display(Name = "Divorced", ShortName = "D")]
    D,
    [Display(Name = "Married", ShortName = "M")]
    M,
    [Display(Name = "Single", ShortName = "S")]
    S,
    [Display(Name = "Widowed", ShortName = "W")]
    W,
    [Display(Name = "Common Law", ShortName = "C")]
    C,
    [Display(Name = "Living Together", ShortName = "G")]
    G,
    [Display(Name = "Domestic Partner", ShortName = "P")]
    P,
    [Display(Name = "Registered Domestic Partner", ShortName = "R")]
    R,
    [Display(Name = "legally Separated", ShortName = "E")]
    E,
    [Display(Name = "Annulled", ShortName = "N")]
    N,
    [Display(Name = "Interlocutory", ShortName = "I")]
    I,
    [Display(Name = "Unmarried", ShortName = "B")]
    B,
    [Display(Name = "Unknown", ShortName = "U")]
    U,
    [Display(Name = "Other", ShortName = "O")]
    O,
    [Display(Name = "Unreported", ShortName = "T")]
    T
  }
}