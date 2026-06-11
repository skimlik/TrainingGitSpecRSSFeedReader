# Research: MVP RSS Reader

## Decision: Singleton Service for Subscription Storage
**Decision**: Use a singleton service (`SubscriptionService`) in the ASP.NET Core Backend to hold an in-memory `List<Subscription>`.
**Rationale**: In-memory storage is requested for the MVP. A singleton service ensures that the same list instance is shared across all API requests during the application's lifetime.
**Alternatives considered**: 
- Static list in Controller: Rejected as it's harder to test and not idiomatic for ASP.NET Core dependency injection.
- Database (SQLite): Rejected as it's explicitly out of scope for the MVP.

## Decision: Configuration-Driven HttpClient in Blazor
**Decision**: Configure the `HttpClient` in `Program.cs` of the Blazor project by reading `ApiBaseUrl` from `builder.Configuration`.
**Rationale**: Adheres to the "Security-First" principle in the project constitution, ensuring the API URL is not hardcoded and can be adjusted per environment.
**Alternatives considered**:
- Hardcoded string: Rejected as it violates the constitution and makes port synchronization fragile.

## Decision: Explicit CORS Origin Mapping
**Decision**: Define a named CORS policy in the Backend that explicitly allows `http://localhost:5213` (and `https://localhost:7025` for SSL).
**Rationale**: Browser security prevents Blazor WASM from making cross-origin requests unless the Backend explicitly allows the Frontend's origin.
**Alternatives considered**:
- Allow All (`*`): Rejected as it's insecure and violates the "Security-First" principle of strict CORS.

## Decision: Standardized Port Configuration
**Decision**: Fix Backend to `5151` and Frontend to `5213` in their respective `launchSettings.json`.
**Rationale**: Provides a consistent development experience and simplifies port synchronization in configuration files.
**Alternatives considered**: 
- Random ports: Rejected as it requires manual update of config files on every run.
