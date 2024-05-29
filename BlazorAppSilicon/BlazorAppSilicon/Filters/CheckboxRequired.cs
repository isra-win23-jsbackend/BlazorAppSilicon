using System.ComponentModel.DataAnnotations;

namespace BlazorAppSilicon.Filters;

public class CheckboxRequired : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;

}