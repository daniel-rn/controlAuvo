using System.Collections.Generic;
using ControlAuvo.Business.Notifications;

namespace ControlAuvo.Business.Interfaces
{
    public interface INotifier
    {
        bool TemNotificacao();
        List<Notification> ObterNotificacoes();
        void Handle(Notification notificacao);
    }
}
