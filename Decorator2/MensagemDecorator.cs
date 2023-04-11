namespace Decorator2;

// Decorador: classe abstrata que define a interface para os decoradores
public abstract class MensagemDecorator : IMensagem
{
    protected IMensagem mensagem;

    protected MensagemDecorator(IMensagem mensagem)
    {
        this.mensagem = mensagem;
    }

    public virtual string Mensagem => mensagem.Mensagem;
}