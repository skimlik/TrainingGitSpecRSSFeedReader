# Develop a greenfield application using GitHub Spec Kit

GitHub Spec Kit is an open-source toolkit that enables Spec-Driven Development (SSD) by integrating specifications with AI coding assistants like GitHub Copilot.

In this exercise, you learn how to use the GitHub Spec Kit to develop a new greenfield application. You begin by initializing the GitHub Spec Kit for a new .NET project. You then use GitHub Spec Kit workflows to create the constitution, specification, plan, and tasks documents for the new application. Finally, you use GitHub Spec Kit’s implementation workflow to implement an initial MVP version of the application.

This exercise takes approximately **60** minutes to complete.

> **IMPORTANT**: To complete this exercise, you must provide your own GitHub account and GitHub Copilot subscription. If you don’t have a GitHub account, you can [sign up](https://github.com/) for a free individual account and use a GitHub Copilot Free plan to complete the exercise.

## Before you start

Your lab environment MUST include the following resources: 
- Git 2.48 or later
- .NET SDK 8.0 or later
- Visual Studio Code with the C# Dev Kit and GitHub Copilot Chat extensions
- Python 3.11 or later
- The `uv` package manager
- Specify CLI
- Access to a GitHub account with GitHub Copilot enabled.

For help with configuring your lab environment, open the following link in a browser: [Configure your GitHub Spec Kit lab environment](https://go.microsoft.com/fwlink/?linkid=2345907).

## Exercise scenario

You’re a software developer working for a consulting firm. Your firm is moving to a spec-driven development methodology using GitHub Spec Kit and GitHub Copilot in Visual Studio Code. You’re asked to start using SDD and GitHub Spec Kit as soon as possible.

One of your clients, Contoso Corporation, needs you to develop an initial MVP version for an RSS feed reader app. Contoso stakeholders documented the project goals, initial features, and technical requirements for the app. You’ll use the stakeholder documents to generate the constitution, spec, plan, and tasks documents, then implement the initial MVP version of the application.

### Tasks in this exercise:
1. Create a project folder and initialize GitHub Spec Kit.
2. Generate the constitution using stakeholder documentation.
3. Generate the `spec.md` file using stakeholder documentation.
4. Generate the `plan.md` file using stakeholder documentation and `spec.md`.
5. Generate the `tasks.md` file using the `spec.md`, `plan.md`, and `constitution.md`.
6. Implement the tasks required for an MVP application.

---

## 1. Create a project folder and initialize GitHub Spec Kit

The Specify CLI is used to initialize GitHub Spec Kit in a project folder.

1. Open a terminal window and navigate to the root of your drive.
   ```bash
   cd C:\
   ```
2. Create a new folder for your project:
   ```bash
   mkdir TrainingProjects\RSSFeedReader
   ```
3. Navigate to the new project folder:
   ```bash
   cd TrainingProjects\RSSFeedReader
   ```
4. Initialize GitHub Spec Kit:
   ```bash
   specify init --here --ai copilot --script ps
   ```
   > **NOTE:** If you’re using macOS or Linux with bash/zsh, replace `--script ps` with `--script sh`.

5. Open the project in Visual Studio Code:
   ```bash
   code .
   ```

6. **Verify Folder Structure**:
   - `.github/agents/`: Executable workflows.
   - `.github/prompts/`: Prompt files for agent workflows.
   - `.specify/memory/`: Stores the project constitution.
   - `.specify/scripts/`: Automation utilities.
   - `.specify/templates/`: Standardized markdown formats.

7. **Verify Commands**: In the Copilot Chat view, type `/speckit` to see available commands like `/speckit.specify`, `/speckit.plan`, etc.

8. **Publish to GitHub**:
   - Open SOURCE CONTROL view.
   - Select **Publish Branch**.
   - Select **Publish to GitHub private repository** (or Public if on a Free plan).

---

## 2. Generate the constitution using stakeholder documentation

The `constitution.md` file defines policies, requirements, and technical standards.

1. **Download Stakeholder Documents**: [RSSFeedReader - stakeholder documents](https://github.com/MicrosoftLearning/mslearn-github-copilot-dev/raw/refs/heads/main/DownloadableCodeProjects/Downloads/GHSpecKitEx13StakeholderDocuments.zip).
2. Extract and paste the `StakeholderDocuments` folder into your project root.
3. **Run the Constitution Workflow**:
   In Copilot Chat, enter:
   ```bash
   /speckit.constitution --text "Code projects emphasize security, maintainability, and code quality. Ensure that all principles are specific, actionable, and relevant to the project context." --files StakeholderDocuments/ProjectGoals.md StakeholderDocuments/AppFeatures.md StakeholderDocuments/TechStack.md
   ```
4. Review the generated `constitution.md`. Ensure principles are clear and actionable.
5. Select **Keep** in the Chat view to accept changes.
6. Commit and push: "Updated constitution using stakeholder requirements."

---

## 3. Generate the spec.md file using stakeholder documentation

The specification defines *what* you’re building from the user’s perspective.

1. **Run the Specify Workflow**:
   In Copilot Chat, enter:
   ```bash
   /speckit.specify --text "MVP RSS reader: a simple RSS/Atom feed reader that demonstrates the most basic capability (add subscriptions) without the complexity of a production-ready application." --files StakeholderDocuments/ProjectGoals.md StakeholderDocuments/AppFeatures.md
   ```
2. **Grant Permissions**: Copilot may ask to create a new branch. Grant permission.
3. **Review `spec.md`**:
   - Check **User Scenarios & Testing** (Given-When-Then format).
   - Check **Requirements** and **Success Criteria**.
4. **Review `requirements.md`**: Ensure all checklist items passed.
5. Accept changes, save, and commit: "Add specification for the RSS Feed Reader app".

---

## 4. Generate the plan.md file using stakeholder documentation and spec.md

The technical plan defines the architecture and technology choices.

1. **Run the Plan Workflow**:
   In Copilot Chat, enter:
   ```bash
   /speckit.plan --files StakeholderDocuments/ProjectGoals.md StakeholderDocuments/TechStack.md
   ```
2. **Review Generated Files**:
   - `plan.md`: Technical implementation strategy.
   - `research.md`: Technology decisions.
   - `quickstart.md`: Setup instructions.
   - `data-model.md`: Data entities and relationships.
3. Accept changes, save, and commit.

---

## 5. Generate the tasks.md file using the spec.md, plan.md, and constitution.md

The `tasks.md` file breaks the plan into actionable steps.

1. **Run the Tasks Workflow**:
   In Copilot Chat, enter:
   ```bash
   /speckit.tasks
   ```
2. **Review `tasks.md`**:
   - Ensure tasks are ordered logically (Setup -> Foundation -> Backend -> Frontend -> Testing).
   - Verify every requirement from `spec.md` maps to a task.
3. Accept changes, save, and commit.

---

## 6. Implement the tasks required for an MVP application

1. **Review Implementation Strategy**: Open `tasks.md` and find the "Implementation Strategy" section. Note the task range for the MVP (e.g., T001 - T050).
2. **Run the Implement Workflow**:
   In Copilot Chat, enter (adjusting the task range as per your `tasks.md`):
   ```bash
   /speckit.implement Implement the MVP First strategy (Tasks: T001 - T050)
   ```
3. **Monitor and Assist**: Provide permissions and feedback as Copilot builds the app task by task.
4. **Accept and Save**: Once complete, accept all changes and save files.
5. **Run the Application**:
   - Start the backend and frontend.
   - If unsure of commands, ask Copilot: "How do I start the backend and frontend apps?"
6. **Manual Testing**:
   - Open the frontend (usually `http://localhost:5213`).
   - Test with URLs like: `https://devblogs.microsoft.com/dotnet/feed/`
   - Verify against acceptance scenarios in `spec.md`.
7. **Debug**: If errors occur (e.g., ambiguous routes), paste the error into Copilot Chat for resolution.

---

## Clean up

- Delete the repository if no longer needed.
- Remove any locally installed tools if they are not required for future work.

---
*© 2025 Microsoft*
