// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0339: Advanced Beneficiary Notice Code
	/// </summary>
	public enum AdvancedBeneficiaryNoticeCode {
		/// <summary>
		/// Service is subject to medical necessity procedures
		/// </summary>
    [Display(Name = "Service is subject to medical necessity procedures")]
		_1,
		/// <summary>
		/// Patient has been informed of responsibility, and agrees to pay for service
		/// </summary>
    [Display(Name = "Patient has been informed of responsibility, and agrees to pay for service")]
		_2,
		/// <summary>
		/// Patient has been informed of responsibility, and asks that the payer be billed
		/// </summary>
    [Display(Name = "Patient has been informed of responsibility, and asks that the payer be billed")]
		_3,
		/// <summary>
		/// Advanced Beneficiary Notice has not been signed
		/// </summary>
    [Display(Name = "Advanced Beneficiary Notice has not been signed")]
		_4
  }
}
