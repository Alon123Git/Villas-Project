using Magic_Villa.Models;
using Magic_Villa.Models.DTO;

namespace Magic_Villa.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqeUser(string userName);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registrationRequestDTO);
    }
}