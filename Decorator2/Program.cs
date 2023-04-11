using Decorator2;

IMensagem mensagem = new MensagemComSaudacao(new MensagemPadrao());

Console.WriteLine(mensagem.Mensagem); // Saída: "Olá, mundo!"