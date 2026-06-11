# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-mvp-rss-reader/`

**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/api.md

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `- [ ] [ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Exact file paths are included in descriptions

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [x] T001 Initialize Backend ASP.NET Core Web API project at `backend/RSSFeedReader.Api`
- [x] T002 Initialize Frontend Blazor WebAssembly project at `frontend/RSSFeedReader.UI`
- [x] T003 [P] Create a solution file and add both projects at the repository root

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure and template cleanup that MUST be complete before ANY user story work begins.

**⚠️ CRITICAL**: No user story work can begin until this phase is complete.

- [x] T004 Remove Blazor template demo pages (Home, Counter, Weather) from `frontend/RSSFeedReader.UI/Pages/`
- [x] T005 [P] Update `frontend/RSSFeedReader.UI/Layout/NavMenu.razor` to remove demo links and prepare for MVP navigation
- [x] T006 [P] Synchronize Backend port to `5151` in `backend/RSSFeedReader.Api/Properties/launchSettings.json`
- [x] T007 [P] Synchronize Frontend port to `5213` in `frontend/RSSFeedReader.UI/Properties/launchSettings.json`
- [x] T008 [P] Configure `ApiBaseUrl` (http://localhost:5151/api/) in `frontend/RSSFeedReader.UI/wwwroot/appsettings.json`
- [x] T009 [P] Configure Backend CORS policy in `backend/RSSFeedReader.Api/Program.cs` to allow `http://localhost:5213`
- [x] T010 Configure `HttpClient` in `frontend/RSSFeedReader.UI/Program.cs` to use the base address from configuration

**Checkpoint**: Foundation ready - user story implementation can now begin.

---

## Phase 3: User Story 1 - Add Feed Subscription (Priority: P1) 🎯 MVP

**Goal**: User can add a feed URL to the subscription list.

**Independent Test**: Enter a URL in the UI, click "Add", and verify the backend receives the request and stores it (can check via console or debugger).

### Implementation for User Story 1

- [x] T011 [P] [US1] Create `Subscription` model in `backend/RSSFeedReader.Api/Models/Subscription.cs`
- [x] T012 [P] [US1] Create `Subscription` model in `frontend/RSSFeedReader.UI/Models/Subscription.cs`
- [x] T013 [US1] Implement `SubscriptionService` in `backend/RSSFeedReader.Api/Services/SubscriptionService.cs` for in-memory storage
- [x] T014 [US1] Register `SubscriptionService` as a singleton in `backend/RSSFeedReader.Api/Program.cs`
- [x] T015 [US1] Implement `POST /api/subscriptions` endpoint in `backend/RSSFeedReader.Api/Controllers/SubscriptionsController.cs`
- [x] T016 [US1] Create Subscriptions management UI in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor` with input field and Add button
- [x] T017 [US1] Implement "Add" logic in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor` to call the Backend API

**Checkpoint**: User Story 1 is functional. Users can add subscriptions to the in-memory list.

---

## Phase 4: User Story 2 - View Subscription List (Priority: P1)

**Goal**: User can see all subscribed feeds in the UI.

**Independent Test**: Add multiple subscriptions and verify they all appear in a list on the Subscriptions page.

### Implementation for User Story 2

- [x] T018 [US2] Implement `GET /api/subscriptions` endpoint in `backend/RSSFeedReader.Api/Controllers/SubscriptionsController.cs`
- [x] T019 [US2] Implement list retrieval and display logic in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor`
- [x] T020 [US2] Add navigation link for the Subscriptions page in `frontend/RSSFeedReader.UI/Layout/NavMenu.razor`

**Checkpoint**: User Story 2 is functional. Users can view their subscription list.

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Final verification and cleanup.

- [x] T021 [P] Verify 100% removal of Blazor template pages and no routing conflicts
- [x] T022 [P] Verify Port consistency across all configuration files
- [x] T023 Run end-to-end validation scenarios from `quickstart.md`

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: Can start immediately.
- **Foundational (Phase 2)**: Depends on Phase 1. BLOCKS all user stories.
- **User Stories (Phase 3 & 4)**: Both are Priority P1 and depend on Phase 2. They can be implemented sequentially or in parallel once the controller/service structure is established.
- **Polish (Phase 5)**: Final step after user stories.

### Parallel Opportunities

- T003 (Solution file) can happen alongside T001/T002.
- Cleanup tasks (T004, T005) and Config tasks (T006-T009) in Phase 2 can run in parallel.
- Models (T011, T012) can be created in parallel.
- US1 and US2 can be worked on in parallel by different developers once the `SubscriptionsController` and `SubscriptionService` skeletons exist.

---

## Implementation Strategy

### MVP First (User Story 1 & 2)

The combination of User Story 1 (Add) and User Story 2 (List) constitutes the MVP.
1. Complete Setup and Foundational cleanup.
2. Implement US1 and US2.
3. **VALIDATE**: Run the `quickstart.md` validation.

### Incremental Delivery

1. Foundation ready (Phase 2 complete).
2. "Add" capability ready (Phase 3 complete).
3. "List" capability ready (Phase 4 complete).
4. System verified.
