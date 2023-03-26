using MagicVilla_Web.Models.DTO;

namespace Magic_Villa.Models.DTO
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
