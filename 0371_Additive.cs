// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
  public enum _371_Additive {
		/// <summary>
		/// Potassium/K EDTA
		/// </summary>
		[Display(Name = "Potassium/K EDTA")]
    EDTK,
		/// <summary>
		/// Sodium/Na EDTA
		/// </summary>
		[Display(Name = "Sodium/Na EDTA")]
    EDTN,
		/// <summary>
		/// Lithium/Li  Heparin
		/// </summary>
		[Display(Name = "Lithium/Li  Heparin")]
    HEPL,
		/// <summary>
		/// Sodium/Na  Heparin
		/// </summary>
		[Display(Name = "Sodium/Na  Heparin")]
    HEPN,
		/// <summary>
		/// 3.2%  Citrate
		/// </summary>
		[Display(Name = "3.2%  Citrate")]
    C32,
		/// <summary>
		/// 3.8%  Citrate
		/// </summary>
		[Display(Name = "3.8%  Citrate")]
    C38,
		/// <summary>
		/// Borate
		/// </summary>
		[Display(Name = "Borate")]
    BOR,
    /// <summary>
    /// 6N HCL
    /// </summary>
    [Display(Name = "6N HCL")]
    HCL6
  }
}
