<!--
SYNC IMPACT REPORT
- Version change: N/A → 1.0.0
- List of modified principles:
  - N/A → I. Security-First Configuration
  - N/A → II. Clean Slate Maintainability
  - N/A → III. Scalable Separation of Concerns
  - N/A → IV. Minimal Viable Implementation (MVP-First)
  - N/A → V. Robust Local Development & Quality
- Added sections:
  - Technology Standards
  - Development Workflow
- Removed sections: None
- Templates requiring updates (✅ updated / ⚠ pending):
  - .specify/templates/plan-template.md (✅ updated)
  - .specify/templates/spec-template.md (✅ updated)
  - .specify/templates/tasks-template.md (✅ updated)
- Follow-up TODOs: None
-->

# Training Git Spec RSS Feed Reader Constitution

## Core Principles

### I. Security-First Configuration
The Backend MUST implement strict CORS policies (specifically allowing the frontend origin). The Frontend MUST NOT hardcode API URLs; they must be retrieved from `appsettings.json` or environment variables to ensure secure and flexible deployment.

### II. Clean Slate Maintainability
ALL boilerplate template code (Home, Counter, Weather pages) MUST be removed from the Blazor project before any feature implementation. Routing conflicts MUST be verified as resolved to prevent runtime exceptions.

### III. Scalable Separation of Concerns
Business logic for feed parsing and subscription management MUST be encapsulated in the Backend API. The Frontend MUST be kept thin, managing only UI state and user interactions to facilitate future migration to persistent storage.

### IV. Minimal Viable Implementation (MVP-First)
MVP features MUST be restricted to subscription list management (Add/Display). Feed fetching, parsing, and persistence are deferred to later phases. No "just-in-case" code for future features should be added to the MVP.

### V. Robust Local Development & Quality
Port consistency across `launchSettings.json` and `appsettings.json` MUST be maintained. Every implementation step MUST be verified through browser testing and API validation before proceeding.

## Technology Standards

- **Backend**: ASP.NET Core Web API
- **Frontend**: Blazor WebAssembly
- **Parsing**: `System.ServiceModel.Syndication` (for Extended-MVP)
- **Storage**: In-memory (MVP), SQLite (Future)

## Development Workflow

1. **Research**: Map required API endpoints and UI components.
2. **Boilerplate Cleanup**: Remove demo pages and verify routes.
3. **Implementation**: Build API first, then UI.
4. **Validation**: Test "Add" and "List" functionality manually and via browser console.

## Governance

- All Pull Requests must be checked against these principles.
- Changes to principles require a MINOR or MAJOR version bump.
- The `GEMINI.md` file serves as the primary guidance for AI-assisted development.

**Version**: 1.0.0 | **Ratified**: 2026-06-11 | **Last Amended**: 2026-06-11
