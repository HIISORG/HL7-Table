// Jeffrey Chen jeffrey.chen@sydney.edu.au 2017
using System.ComponentModel.DataAnnotations;
namespace HL7Table {
	/// <summary>
	/// HL7 Table 0127: Allergen Type
	/// </summary>
	public enum AllergenType {
		/// <summary>
		/// Animal Allergy
		/// </summary>
		[Display(Name = "Animal Allergy")]
    AA,
		/// <summary>
		/// Drug allergy
		/// </summary>
		[Display(Name = "Drug allergy")]
    DA,
		/// <summary>
		/// Environmental Allergy
		/// </summary>
		[Display(Name = "Environmental Allergy")]
    EA,
		/// <summary>
		/// Food allergy
		/// </summary>
		[Display(Name = "Food allergy")]
    FA,
		/// <summary>
		/// Pollen Allergy
		/// </summary>
		[Display(Name = "Pollen Allergy")]
    LA,
		/// <summary>
		/// Miscellaneous allergy
		/// </summary>
		[Display(Name = "Miscellaneous allergy")]
    MA,
		/// <summary>
		/// Miscellaneous contraindication
		/// </summary>
		[Display(Name = "Miscellaneous contraindication")]
    MC,
		/// <summary>
		/// Plant Allergy
		/// </summary>
		[Display(Name = "Plant Allergy")]
    PA
  }
}
