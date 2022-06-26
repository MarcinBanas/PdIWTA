using PdiwtA.Controllers;
using System.ComponentModel.DataAnnotations;

namespace PdiwtA.DTO
{
    public class TestUserDTO
    {
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}
