namespace template_net_9.DTOs.Auth
{
    public class AuthResponseDTO
    {
        public TokenDTO AuthToken { get; set; } = new TokenDTO();
        public TokenDTO RefreshToken { get; set; } = new TokenDTO();
        public string TokenType { get; set; }
        public ApplicationUserPrivateDTO AuthState { get; set; }
    }

    public class TokenDTO
    {
        public string Token { get; set; }
        public int ExpiresIn { get; set; }
    }
}
