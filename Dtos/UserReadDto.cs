namespace Cake.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string ProfilePicUrl { get; set; }
    }
}