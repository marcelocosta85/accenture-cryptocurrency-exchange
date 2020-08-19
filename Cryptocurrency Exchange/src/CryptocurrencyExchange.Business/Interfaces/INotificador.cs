using CryptocurrencyExchange.Business.Notificações;
using System.Collections.Generic;

namespace CryptocurrencyExchange.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
