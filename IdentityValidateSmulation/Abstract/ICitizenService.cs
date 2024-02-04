using IdentityValidateSmulation.Entities;

namespace IdentityValidateSmulation.Abstract
{
    internal interface ICitizenService
    {
        void Validate(Citizen citizen);
    }
}
