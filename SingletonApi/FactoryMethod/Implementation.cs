namespace SingletonApi.FactoryMethod;

public interface IAuthenticator
{
    bool Authenticate(string credentials);
}

public class JwtAuthenticator : IAuthenticator
{
    public bool Authenticate(string token)
    {
        // Lógica de autenticação JWT
        // Retorna true se o token for válido, caso contrário, false
        return true;
    }
}

public class UserCredentialsAuthenticator : IAuthenticator
{
    public bool Authenticate(string credentials)
    {
        //Lógica de autenticação por credenciais de usuário
        // Retorna true se as credenciais forem válidas, caso contrário, false
        return false;
    }
}

public class AuthenticatorFactory
{
    public static IAuthenticator CreateAuthenticator(string authType)
    {
        if (authType.Equals("jwt", StringComparison.OrdinalIgnoreCase))
        {
            return new JwtAuthenticator();
        }
        else if (authType.Equals("userCredentials", StringComparison.OrdinalIgnoreCase))
        {
            return new UserCredentialsAuthenticator();
        }

        throw new ArgumentException("Invalid authentication type.");
    }
}

