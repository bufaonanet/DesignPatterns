namespace Decorator2;

// Decorador concreto: adiciona comportamentos adicionais ao objeto decorado
public class MensagemComSaudacao : MensagemDecorator
{
    public MensagemComSaudacao(IMensagem mensagem) : base(mensagem)
    {
    }

    public override string Mensagem => $"Olá, {base.Mensagem} ";
}
