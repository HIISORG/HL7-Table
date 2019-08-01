using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0002: Marrital status.
  /// </summary>
  public enum MarritalStatus {
    [Display(Name = "")]
    None,
    /// <summary>
    /// Seperated
    /// </summary>
    [Display(Name = "Separated", ShortName = "A", Description = "Separated")]
    A,
    /// <summary>
    /// Divorced
    /// </summary>
    [Display(Name = "Divorced", ShortName = "D", Description = "Divorced")]
    D,
    /// <summary>
    /// Married
    /// </summary>
    [Display(Name = "Married", ShortName = "M", Description = "Married")]
    M,
    /// <summary>
    /// Single
    /// </summary>
    [Display(Name = "Single", ShortName = "S", Description = "Single")]
    S,
    /// <summary>
    /// Widowed
    /// </summary>
    [Display(Name = "Widowed", ShortName = "W", Description = "Widowed")]
    W,
    /// <summary>
    /// Common law
    /// </summary>
    [Display(Name = "Common Law", ShortName = "C", Description = "Common Law")]
    C,
    /// <summary>
    /// Living together
    /// </summary>
    [Display(Name = "Living Together", ShortName = "G", Description = "Living Together")]
    G,
    /// <summary>
    /// Domestic Partner
    /// </summary>
    [Display(Name = "Domestic Partner", ShortName = "P", Description = "Domestic Partner")]
    P,
    /// <summary>
    /// Registered domestic partner
    /// </summary>
    [Display(Name = "Registered Domestic Partner", ShortName = "R", Description = "Registered Domestic Partner")]
    R,
    /// <summary>
    /// Legal seperated
    /// </summary>
    [Display(Name = "Legally Separated", ShortName = "E", Description = "Legal Separated")]
    E,
    /// <summary>
    /// Annulled
    /// </summary>
    [Display(Name = "Annulled", ShortName = "N", Description = "Annulled")]
    N,
    /// <summary>
    /// Interlocutory
    /// </summary>
    [Display(Name = "Interlocutory", ShortName = "I", Description = "Interlocutory")]
    I,
    /// <summary>
    /// Unmarried
    /// </summary>
    [Display(Name = "Unmarried", ShortName = "B", Description = "Unmarried")]
    B,
    /// <summary>
    /// Unknown
    /// </summary>
    [Display(Name = "Unknown", ShortName = "U", Description = "Unknown")]
    U,
    /// <summary>
    /// Other
    /// </summary>
    [Display(Name = "Other", ShortName = "O", Description = "Other")]
    O,
    /// <summary>
    /// Unreported
    /// </summary>
    [Display(Name = "Unreported", ShortName = "T", Description = "Unreported")]
    T
  }
}