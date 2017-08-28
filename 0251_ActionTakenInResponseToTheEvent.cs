// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// Table 0251: Action Taken in Response to the Event
  /// </summary>
  public enum ActionTakenInResponseToTheEvent {
    /// <summary>
    /// Product dose or frequency of use increased
    /// </summary>
    [Display(Name = "Product dose or frequency of use increased")]
    DI,
    /// <summary>
    /// Product dose or frequency of use reduced
    /// </summary>
    [Display(Name = "Product dose or frequency of use reduced")]
    DR,
    /// <summary>
    /// None
    /// </summary>
    [Display(Name = "None")]
    N,
    /// <summary>
    /// Other
    /// </summary>
    [Display(Name = "Other")]
    OT,
    /// <summary>
    /// Product withdrawn permanently
    /// </summary>
    [Display(Name = "Product withdrawn permanently")]
    WP,
    /// <summary>
    /// Product withdrawn temporarily
    /// </summary>
    [Display(Name = "Product withdrawn temporarily")]
    WT
  }
}