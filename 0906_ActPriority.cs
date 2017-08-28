// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  /// <summary>
  /// 0906: ActPriority, version 2.7
  /// </summary>
  public enum ActPriority {
    /// <summary>
    /// ASAP - As soon as possible, next highest priority after stat
    /// </summary>
    [Display(Name = "ASAP - As soon as possible, next highest priority after stat")]
    A,
    /// <summary>
    /// Callback results - filler should contact the placer as soon as results are available, even for preliminary results
    /// </summary>
    [Display(Name = "Callback results - filler should contact the placer as soon as results are available, even for preliminary results")]
    CR,
    /// <summary>
    /// Callback for scheduling - Filler should contact the placer (or target) to schedule the service.
    /// </summary>
    [Display(Name = "Callback for scheduling - Filler should contact the placer (or target) to schedule the service.")]
    CS,
    /// <summary>
    /// Callback placer for scheduling - filler should contact the placer to schedule the service
    /// </summary>
    [Display(Name = "Callback placer for scheduling - filler should contact the placer to schedule the service")]
    CSP,
    /// <summary>
    /// Contact recipient for scheduling - Filler should contact the service recipient (target) to schedule the service
    /// </summary>
    [Display(Name = "Contact recipient for scheduling - Filler should contact the service recipient (target) to schedule the service")]
    CSR,
    /// <summary>
    /// Elective - Beneficial to the patient but not essential for survival.
    /// </summary>
    [Display(Name = "Elective - Beneficial to the patient but not essential for survival.")]
    EL,
    /// <summary>
    /// Emergency - An unforeseen combination of circumstances or the resulting state that calls for immediate action
    /// </summary>
    [Display(Name = "Emergency - An unforeseen combination of circumstances or the resulting state that calls for immediate action")]
    EM,
    /// <summary>
    /// Preop - Used to indicate that a service is to be performed prior to a scheduled surgery. When ordering a service and using the pre-op priority, a check is done to see the amount of time that must be allowed for performance of the service. When the order
    /// </summary>
    [Display(Name = "Preop - Used to indicate that a service is to be performed prior to a scheduled surgery. When ordering a service and using the pre-op priority, a check is done to see the amount of time that must be allowed for performance of the service. When the order")]
    P,
    /// <summary>
    /// As needed - An "as needed" order should be accompanied by a description of what constitutes a need. This description is represented by an observation service predicate as a precondition.
    /// </summary>
    [Display(Name = "As needed - An \"as needed\" order should be accompanied by a description of what constitutes a need. This description is represented by an observation service predicate as a precondition.")]
    PRN,
    /// <summary>
    /// Routine - Routine service, do at usual work hours
    /// </summary>
    [Display(Name = "Routine - Routine service, do at usual work hours")]
    R,
    /// <summary>
    /// Rush reporting - A report should be prepared and sent as quickly as possible
    /// </summary>
    [Display(Name = "Rush reporting - A report should be prepared and sent as quickly as possible")]
    RR,
    /// <summary>
    /// Stat - With highest priority (e.g. emergency).
    /// </summary>
    [Display(Name = "Stat - With highest priority (e.g. emergency).")]
    S,
    /// <summary>
    /// Timing critical - It is critical to come as close as possible to the requested time (e.g. for a through antimicrobial level).
    /// </summary>
    [Display(Name = "Timing critical - It is critical to come as close as possible to the requested time (e.g. for a through antimicrobial level).")]
    T,
    /// <summary>
    /// Use as directed - Drug is to be used as directed by the prescriber.
    /// </summary>
    [Display(Name = "Use as directed - Drug is to be used as directed by the prescriber.")]
    UD,
    /// <summary>
    /// Urgent - Calls for prompt action
    /// </summary>
    [Display(Name = "Urgent - Calls for prompt action")]
    UR
  }
}