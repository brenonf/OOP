
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student: Base
    {
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive);
    }
}