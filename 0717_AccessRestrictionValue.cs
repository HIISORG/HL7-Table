// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AccessRestrictionValue {
    /// <summary>
    /// All
    /// </summary>
    [Display(Name = "All")]
    ALL,
    /// <summary>
    /// All demographic data
    /// </summary>
    [Display(Name = "All demographic data")]
    DEM,
    /// <summary>
    /// Drug
    /// </summary>
    [Display(Name = "Drug")]
    DRG,
    /// <summary>
    /// HIV status and results
    /// </summary>
    [Display(Name = "HIV status and results")]
    HIV,
    /// <summary>
    /// Patient Location
    /// </summary>
    [Display(Name = "Patient Location")]
    LOC,
    /// <summary>
    /// None
    /// </summary>
    [Display(Name = "None")]
    NO,
    /// <summary>
    /// Opt in all registries (HIPAA)
    /// </summary>
    [Display(Name = "Opt in all registries (HIPAA)")]
    OI,
    /// <summary>
    /// Opt out all registries (HIPAA)
    /// </summary>
    [Display(Name = "Opt out all registries (HIPAA)")]
    OO,
    /// <summary>
    /// Religion
    /// </summary>
    [Display(Name = "Religion")]
    PID_17,
    /// <summary>
    /// Date of Birth
    /// </summary>
    [Display(Name = "Date of Birth")]
    PID_7,
    /// <summary>
    /// Psychiatric Mental health
    /// </summary>
    [Display(Name = "Psychiatric Mental health")]
    PSY,
    /// <summary>
    /// Sensitive medical data
    /// </summary>
    [Display(Name = "Sensitive medical data")]
    SMD,
    /// <summary>
    /// Sexually transmitted diseases
    /// </summary>
    [Display(Name = "Sexually transmitted diseases")]
    STD
  }
}