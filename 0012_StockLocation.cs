// Jeffrey Chen jeffrey@hiis.org 2019
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 v2.9 Table 0012 Stock Location
  /// </summary>
  public enum StockLocation {
    /// <summary>
    /// from v2.1, removed after v2.2
    /// </summary>
    [Display(Name = "Filled from ancillary department stock")]
    AN,
    /// <summary>
    /// from v2.1, removed after v2.2
    /// </summary>
    [Display(Name = "Filled from floor stock")]
    FL
  }
}
