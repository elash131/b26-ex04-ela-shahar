# Agent Context For Exercise 4

Read this file first when working on this repository.

The user wants all future help to stay aligned with Exercise 4, not Exercise 3. Always answer the user in English.

## Workspace Map

Root workspace:

```text
C:\Dev\C#\B26 Ex04 ElaShaul 318481066 ShaharNuss 207108846
```

Exercise material folder:

```text
DN_2026B_Ex04\
```

Visual Studio solution folder:

```text
Ex04 Ela 318481066 Shahar 207108846\
```

## Solution Folder

This folder contains the code that should be edited and submitted:

```text
Ex04 Ela 318481066 Shahar 207108846\
|-- Ex04 Ela 318481066 Shahar 207108846.sln
|-- Ex04.Menus.Interfaces\
|-- Ex04.Menus.Events\
`-- Ex04.Menus.Test\
```

Current local warning: the interface project may have been created with the misspelled folder/project name `Ex04.Menus.Interaces`. The assignment spelling is `Ex04.Menus.Interfaces`.

## Reference Material Folder

This folder is for reading only:

```text
DN_2026B_Ex04\
|-- DN_2026B_Ex04.pdf
|-- DN_2026B_Ex04_extracted.txt
|-- Docs\
|-- מצגות\
`-- דוגמאות קוד\
```

Do not add any of these reference files or folders to the Visual Studio solution.

## Agent Reading Order

When starting work, read in this order:

1. `DN_2026B_Ex04\Docs\AGENT_CONTEXT.md`
2. `DN_2026B_Ex04\Docs\README.md`
3. `DN_2026B_Ex04\Docs\Assistant_Guardrails.md`
4. `DN_2026B_Ex04\Docs\Visual_Studio_Workflow.md`
5. `DN_2026B_Ex04\Docs\Coding_Standards.md`
6. `DN_2026B_Ex04\Docs\Submission_Rules.md`
7. `DN_2026B_Ex04\DN_2026B_Ex04.pdf` or `DN_2026B_Ex04_extracted.txt` when exact assignment wording is needed
8. `DN_2026B_Ex04\מצגות\` and `DN_2026B_Ex04\דוגמאות קוד\` only when course concept confirmation is needed

## Which File To Use For What

Use `README.md` for:

- assignment summary
- required architecture
- menu behavior
- project responsibilities

Use `Assistant_Guardrails.md` for:

- non-negotiable assistant rules
- architecture boundaries
- implementation constraints
- review rules

Use `Visual_Studio_Workflow.md` for:

- project types
- project references
- startup project
- Visual Studio setup checks

Use `Coding_Standards.md` for:

- naming conventions
- method style
- event/interface conventions
- course style limitations

Use `Submission_Rules.md` for:

- final folder structure
- generated folders to remove
- final behavior checklist
- pre-submission verification

Use `DN_2026B_Ex04_extracted.txt` for:

- quick searching inside the PDF text
- checking exact required menu labels
- checking sample output

Use `DN_2026B_Ex04.pdf` for:

- source-of-truth assignment wording
- visual confirmation of PDF pages

Use `מצגות` for:

- confirming which C# concepts were taught
- checking course-approved syntax and OOP concepts

Use `דוגמאות קוד` for:

- course-approved examples of interfaces, callbacks, delegates, and events
- understanding the "worker announces sickness" style callback problem referenced in the assignment

## Required Exercise 4 Implementation

Build a reusable console menu mechanism twice:

```text
Ex04.Menus.Interfaces
Ex04.Menus.Events
```

Then demonstrate both in:

```text
Ex04.Menus.Test
```

Required test menu shape:

```text
Main Menu
|-- Show Current Date/Time
|   |-- Show Current Date
|   `-- Show Current Time
`-- Version and Capitals
    |-- Count Capitals
    `-- Show Version
```

Required action output:

- `Show Current Date`: print current date
- `Show Current Time`: print current time
- `Count Capitals`: ask for text and count uppercase letters
- `Show Version`: print `App Version: 26.2.4.7310`

## Do Not Bring From Exercise 3

Do not use or mention these Exercise 3 concepts in implementation unless the user explicitly asks:

```text
Garage
GarageLogic
ConsoleUI
Vehicle
VehicleCreator
VehiclesDB.txt
Ex03_ClassDiagram.docx
```

## Final Reminder

The Markdown docs are local working guidance. The submitted solution should contain only the required solution and project source files, plus any files explicitly required by the lecturer.
