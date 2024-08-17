using System;
using System.ComponentModel.DataAnnotations;

public class DateGreaterThan : ValidationAttribute
{
    private readonly string _startDatePropertyName;

    public DateGreaterThan(string startDatePropertyName)
    {
        _startDatePropertyName = startDatePropertyName;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var endDate = (DateTime?)value;

        var startDatePropertyInfo = validationContext.ObjectType.GetProperty(_startDatePropertyName);

        if (startDatePropertyInfo == null)
            throw new ArgumentException($"Property '{_startDatePropertyName}' not found");

        var startDate = (DateTime?)startDatePropertyInfo.GetValue(validationContext.ObjectInstance);

        if (endDate <= startDate)
        {
            return new ValidationResult(ErrorMessage ?? $"{validationContext.DisplayName} must be greater than {_startDatePropertyName}");
        }

        return ValidationResult.Success;
    }
}
