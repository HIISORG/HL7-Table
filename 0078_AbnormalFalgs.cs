// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum AbnormalFalgs {
		/// <summary>
		/// Below low normal
		/// </summary>
		[Display(Name = "Below low normal")]
    L,
		/// <summary>
		///   Above high normal
		/// </summary>
		[Display(Name = "Above high normal")]
    H,
		/// <summary>
		/// Below lower panic limits
		/// </summary>
		[Display(Name = "Below lower panic limits")]
    LL,
		/// <summary>
		/// Above upper panic limits
		/// </summary>
		[Display(Name = "Above upper panic limits")]
    HH,
		/// <summary>
		/// Below absolute low-off instrument scale
		/// </summary>
		[Display(Name = "Below absolute low-off instrument scale")]
    _0x60,
		/// <summary>
		/// Above absolute high-off instrument scale
		/// </summary>
		[Display(Name = "Above absolute high-off instrument scale")]
    _0x62,
		/// <summary>
		/// Normal (applies to non-numeric results)
		/// </summary>
		[Display(Name = "Normal (applies to non-numeric results)")]
    N,
		/// <summary>
		/// Abnormal (applies to non-numeric results)
		/// </summary>
		[Display(Name = "Abnormal (applies to non-numeric results)")]
    A,
		/// <summary>
		/// Very abnormal (applies to non-numeric units, analogous to panic limits for numeric units)
		/// </summary>
		[Display(Name = "Very abnormal (applies to non-numeric units, analogous to panic limits for numeric units)")]
    AA,
		/// <summary>
		/// Significant change up
		/// </summary>
		[Display(Name = "Significant change up")]
    U,
		/// <summary>
		/// Significant change down
		/// </summary>
		[Display(Name = "Significant change down")]
    D,
		/// <summary>
		/// Better--use when direction not relevant
		/// </summary>
		[Display(Name = "Better--use when direction not relevant")]
    B,
		/// <summary>
		/// Worse--use when direction not relevant
		/// </summary>
		[Display(Name = "Worse--use when direction not relevant")]
    W,
		/// <summary>
		/// Susceptible. Indicates for microbiology susceptibilities only.
		/// </summary>
		[Display(Name = "Susceptible. Indicates for microbiology susceptibilities only.")]
    S,
		/// <summary>
		/// Resistant. Indicates for microbiology susceptibilities only.
		/// </summary>
		[Display(Name = "Resistant. Indicates for microbiology susceptibilities only.")]
    R,
		/// <summary>
		/// Intermediate. Indicates for microbiology susceptibilities only.
		/// </summary>
		[Display(Name = "Intermediate. Indicates for microbiology susceptibilities only.")]
    I,
		/// <summary>
		/// Moderately susceptible. Indicates for microbiology susceptibilities only.
		/// </summary>
		[Display(Name = "Moderately susceptible. Indicates for microbiology susceptibilities only.")]
    MS,
		/// <summary>
		/// Very susceptible. Indicates for microbiology susceptibilities only.
		/// </summary>
		[Display(Name = "Very susceptible. Indicates for microbiology susceptibilities only.")]
    VS
  }
}
