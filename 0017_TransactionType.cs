// Jeffrey Chen jeffrey@hiis.org 2019
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 v2.9 Table 0017 Transaction Type
  /// </summary>
  public enum TransactionType {
    /// <summary>
    /// Adjustment
    /// Added v2.3
    /// </summary>
    [Display(Name = "Adjustment")]
    AJ,
    /// <summary>
    /// Credit
    /// Added v2.3
    /// </summary>
    [Display(Name = "Credit")]
    CD,
    /// <summary>
    /// Charge
    /// Added v2.3
    /// </summary>
    [Display(Name = "Charge")]
    CG,
    /// <summary>
    /// Co-payment
    /// Added v2.4
    /// </summary>
    [Display(Name = "Co-payment")]
    CO,
    /// <summary>
    /// Payment
    /// Added v2.3
    /// </summary>
    [Display(Name = "Payment")]
    PY
  }
}
