using CustomerSupport.Application.DTOs.Auth;
using CustomerSupport.Domain.Entities;

namespace CustomerSupport.Application.Mappings
{
    public static class UserMappingExtensions
    {
        public static User ToEntity(this RegisterRequestDTO request)
        {
            return new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,

                // Public self-registration should always creates a customer
                // The client must never be allowed to register itself
                // as a support executive or administrator
                RoleId = Domain.Enums.RoleType.Customer,
                IsActive = true
            };
        }

        public static UserResponseDTO ToResponseDTO(this User user)
        {
            return new UserResponseDTO
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}".Trim(),
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Role = user.RoleId.ToString(),
                IsActive = user.IsActive
            };
        }
    }
}