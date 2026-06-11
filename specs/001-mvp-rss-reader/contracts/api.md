# API Contracts: MVP RSS Reader

## Subscriptions API

### Get All Subscriptions
Retrieves the list of all feed URLs currently in the subscription list.

- **Endpoint**: `GET /api/subscriptions`
- **Response Body**:
  ```json
  [
    {
      "url": "https://devblogs.microsoft.com/dotnet/feed/"
    }
  ]
  ```
- **Status Codes**:
  - `200 OK`: Success

---

### Add Subscription
Adds a new feed URL to the subscription list.

- **Endpoint**: `POST /api/subscriptions`
- **Request Body**:
  ```json
  {
    "url": "https://example.com/rss"
  }
  ```
- **Status Codes**:
  - `201 Created`: Successfully added
  - `400 Bad Request`: Invalid URL provided
