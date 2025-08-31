using System.ComponentModel.DataAnnotations;

namespace Data_Annotation_Validation_Using_Controller.Validators;

public static class WarrantyValidator
{
    public static ValidationResult? MustBe12_24_36(int value)
    {
        return value == 0 || value == 12 || value == 24 || value == 36
            ? ValidationResult.Success
            : new ValidationResult("Warranty must be 0, 12, 24, or 36 months only.");
    }
}