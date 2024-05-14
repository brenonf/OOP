using Balta.NotificationContext;
using Balta.SharedContext;
using System.Collections.Generic;

namespace Balta.SubscriptionContext
{
    public class Student: Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>(); 
        }

        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já possui uma assinatura ativa!"));
                return;
            }
            else
            {
                Subscriptions.Add(subscription);
                return;
            }
        }
        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive);
    }
}