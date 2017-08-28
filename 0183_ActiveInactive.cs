// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// 0183: Active/Inactive
  /// </summary>
  public enum ActiveInactive {
    /// <summary>
    /// Active Staff
    /// </summary>
    [Display(Name = "Active staff")]
    A,
    /// <summary>
    /// Inactive staff
    /// </summary>
    [Display(Name = "Inactive staff")]
    I
  }
}