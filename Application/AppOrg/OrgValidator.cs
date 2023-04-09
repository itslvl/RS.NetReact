using Domain;
using FluentValidation;
// using Domain;

namespace Application.AppOrg
{
    public class OrgValidator : AbstractValidator<Org>
    {
        public OrgValidator()
        {
            RuleFor( a => a.OrgName).NotEmpty();
            RuleFor( a => a.Parent).NotEmpty();
            // RuleFor( a => a.Deleted).NotEmpty();  // Karena Default Value adalah 0
            // RuleFor( a => a.).NotEmpty();
        }
    }
}