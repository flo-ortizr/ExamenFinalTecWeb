namespace ProyectoFinalTecWeb.Entities.Dtos.Auth
{
    public class ResetPasswordDto
    {
        public string Email { get; init; } = string.Empty;
        public string newPassword { get; init; } = string.Empty;
    }
}
