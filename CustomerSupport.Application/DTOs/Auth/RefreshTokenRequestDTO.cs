using System.ComponentModel.DataAnnotations;

namespace CustomerSupport.Application.DTOs.Auth
{
    public sealed class RefreshTokenRequestDTO
    {
        [Required(ErrorMessage = "Refresh token is required.")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}