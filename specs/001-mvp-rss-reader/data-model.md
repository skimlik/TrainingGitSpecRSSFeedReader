# Data Model: MVP RSS Reader

## Subscription
Represents a user's subscription to an RSS or Atom feed.

| Field | Type | Description | Validation |
|-------|------|-------------|------------|
| Url   | string | The absolute URL of the feed | Required, must be a valid URI format |

## Relationships
- This MVP uses a simple list of `Subscription` objects.
- No relationships to other entities are defined for this phase.

## State Transitions
- **Added**: A new URL is added to the in-memory list.
- **Listed**: All URLs currently in the list are retrieved for display.
