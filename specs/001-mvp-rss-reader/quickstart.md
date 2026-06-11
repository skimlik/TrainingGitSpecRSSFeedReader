# Quickstart Validation Guide: MVP RSS Reader

This guide provides steps to verify the MVP RSS Reader functionality end-to-end.

## Prerequisites
- .NET 8 SDK installed
- Browser (Chrome, Firefox, or Safari)

## Setup and Run

### 1. Start Backend API
```bash
cd backend/RSSFeedReader.Api
dotnet run
```
- Verify API is listening on `http://localhost:5151`
- Optional: Open `http://localhost:5151/swagger` to test endpoints manually.

### 2. Start Frontend UI
```bash
cd frontend/RSSFeedReader.UI
dotnet run
```
- Verify UI is running on `http://localhost:5213`
- Open the browser to `http://localhost:5213`

## Validation Scenarios

### Scenario 1: Add a subscription
1. Navigate to the Subscriptions page in the UI.
2. Enter `https://devblogs.microsoft.com/dotnet/feed/` in the input field.
3. Click **Add**.
4. **Expected Outcome**: The URL appears in the list below the input field within 500ms.

### Scenario 2: Verify in-memory persistence (session)
1. Add two different URLs.
2. Refresh the browser page.
3. **Expected Outcome**: Both URLs remain in the list (since they are stored in the Backend singleton).

### Scenario 3: Verify clean slate
1. Navigate to the root URL `/`.
2. **Expected Outcome**: Only the RSS Reader interface is visible. No "Counter" or "Weather" pages should be linked or accessible.
