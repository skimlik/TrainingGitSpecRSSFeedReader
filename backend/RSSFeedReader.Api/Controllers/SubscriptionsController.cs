using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionService _subscriptionService;

    public SubscriptionsController(SubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpGet]
    public ActionResult<List<Subscription>> Get()
    {
        return Ok(_subscriptionService.GetAll());
    }

    [HttpPost]
    public ActionResult Post([FromBody] Subscription subscription)
    {
        _subscriptionService.Add(subscription);
        return CreatedAtAction(nameof(Get), null);
    }
}
