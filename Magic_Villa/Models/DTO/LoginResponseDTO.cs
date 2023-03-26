using Microsoft.Extensions.Primitives;

namespace Magic_Villa.Models.DTO
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
