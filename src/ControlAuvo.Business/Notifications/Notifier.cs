using System.Collections.Generic;
using System.Linq;
using ControlAuvo.Business.Interfaces;

namespace ControlAuvo.Business.Notifications
{
    public class Notifier : INotifier
    {
        private readonly List<Notification> _notificacoes;

        public Notifier()
        {
            _notificacoes = new List<Notification>();
        }

        public void Handle(Notification notification)
        {
            _notificacoes.Add(notification);
        }

        public List<Notification> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
