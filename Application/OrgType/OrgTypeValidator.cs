using Domain.R;
using FluentValidation;

namespace Application.OrgType
{
    public class OrgTypeValidator : AbstractValidator<ROrgType>
    {
        public OrgTypeValidator()
        {
            RuleFor( a => a.Code).NotEmpty();
            RuleFor( a => a.Definition).NotEmpty();
            // RuleFor( a => a.Deleted).NotEmpty();  // Karena Default Value adalah 0
            RuleFor( a => a.Display).NotEmpty();
        }
    }
}