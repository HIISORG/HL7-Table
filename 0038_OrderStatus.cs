// Jeffrey Chen jeffrey@hiis.org 2019
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// HL7 Table 0038 Order Status
  /// </summary>
  public enum OrderStatus {
    /// <summary>
    /// Some, but not all, resutls avaible
    /// added v2.3
    /// </summary>
    [Display(Name = "Some, but not all, results avaible", ShortName = "A")]
    A,
    /// <summary>
    /// Order was cancelled
    /// from v2.1
    /// </summary>
    [Display(Name = "Order was canceled", ShortName = "CA")]
    CA,
    /// <summary>
    /// Order is completed
    /// from v2.1
    /// </summary>
    [Display(Name = "Order is completed", ShortName = "CM")]
    CM,
    /// <summary>
    /// Order was discountinued
    /// from v2.1
    /// </summary>
    [Display(Name = "Order was discountinued", ShortName = "DC")]
    DC,
    /// <summary>
    /// Error, order not found
    /// from v2.1
    /// </summary>
    [Display(Name = "Error, order not found", ShortName = "ER")]
    ER,
    /// <summary>
    /// Order is on hold
    /// from v2.1
    /// </summary>
    [Display(Name = "Order is on hold", ShortName = "HD")]
    HD,
    /// <summary>
    /// In process, unspecified
    /// from v2.1
    /// </summary>
    [Display(Name = "In process, unspecified", ShortName = "IP")]
    IP,
    /// <summary>
    /// Order has been replaced
    /// added from v2.2
    /// </summary>
    [Display(Name = "Order has been replaced", ShortName = "RP")]
    RP,
    /// <summary>
    /// In process, scheduled
    /// from v2.1
    /// </summary>
    [Display(Name = "In process, sheduled", ShortName = "SC")]
    SC
  }
}
