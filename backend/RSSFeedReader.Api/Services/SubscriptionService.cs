using RSSFeedReader.Api.Models;

namespace RSSFeedReader.Api.Services;

public class SubscriptionService
{
    private readonly List<Subscription> _subscriptions = new();

    public List<Subscription> GetAll()
    {
        return _subscriptions;
    }

    public void Add(Subscription subscription)
    {
        if (!string.IsNullOrWhiteSpace(subscription.Url))
        {
            _subscriptions.Add(subscription);
        }
    }
}
