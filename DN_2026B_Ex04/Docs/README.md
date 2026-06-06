# Ex04 Project Notes

This folder contains local working notes for **Exercise 4 - Interfaces, Delegates, Events, and Console Menus**.

These notes are for planning, code-quality guidance, and agent orientation only. They must stay outside the submitted Visual Studio solution and must not be referenced by the `.sln`, `.csproj`, or source code files.

## Assignment Summary

The assignment is to implement a reusable component for showing and managing hierarchical menus in Console applications.

The component should let another programmer build a menu tree made of menu items. A selected item can either:

- open a submenu
- activate an action in the application that uses the menu component

The same menu behavior must be implemented twice, using two different notification techniques:

- interfaces
- delegates/events/`Action<T>`

## Required Solution Structure

The solution must contain exactly these three projects:

```text
Ex04.Menus.Interfaces
Ex04.Menus.Events
Ex04.Menus.Test
```

`Ex04.Menus.Interfaces` is a C# Class Library. It contains the menu implementation that uses interfaces.

`Ex04.Menus.Events` is a C# Class Library. It contains the menu implementation that uses delegates/events/`Action<T>`.

`Ex04.Menus.Test` is a C# Console App. It demonstrates both menu implementations.

## Important Naming Note

The assignment PDF names the first library:

```text
Ex04.Menus.Interfaces
```

If the local project was accidentally created as `Ex04.Menus.Interaces`, that spelling should be corrected before final submission unless the user explicitly decides otherwise.

## Required Runtime Behavior

Calling `MainMenu.Show()` should start the menu loop.

At each menu level:

- show the current menu title
- show the current menu items numbered from `1`
- show `0. Back` for submenus
- show `0. Exit` for the main menu
- ask the user for a choice
- validate the input
- if the choice is invalid, show an error and ask again
- if the selected item has children, clear the screen and navigate to the submenu
- if the selected item has no children, activate its action
- after an action finishes, show the same menu level again

Menu titles should be printed in green using `Console.ForegroundColor`.

These menu libraries are console-menu components, so they may read from and write to `Console`.

## Required Test Menu

`Ex04.Menus.Test` must build two menus in `Main`:

- one menu using `Ex04.Menus.Interfaces`
- one menu using `Ex04.Menus.Events`

The first menu should be shown first. When the user exits it, the second menu should be shown.

Each menu should have two levels:

```text
Main Menu
|-- Show Current Date/Time
|   |-- Show Current Date
|   `-- Show Current Time
`-- Version and Capitals
    |-- Count Capitals
    `-- Show Version
```

The action items should indirectly call methods in `Ex04.Menus.Test`:

- `Show Current Date` prints today's date
- `Show Current Time` prints the current time
- `Count Capitals` asks for a sentence and prints the number of uppercase letters
- `Show Version` prints `App Version: 26.2.4.7310`

## Interface-Based Architecture Direction

In `Ex04.Menus.Interfaces`, a leaf `MenuItem` should notify the application through an interface.

Expected idea:

```text
MenuItem
has title
has submenu items
optionally has an object implementing an action interface

When a leaf item is selected:
MenuItem calls the interface method on that object
```

The interface should be public because `Ex04.Menus.Test` needs to implement it or pass implementers to the menu library.

Possible class names:

```text
MainMenu
MenuItem
IMenuItemSelectedObserver
```

Exact names may be adjusted, but they should remain simple, meaningful, and aligned with course conventions.

## Event-Based Architecture Direction

In `Ex04.Menus.Events`, a leaf `MenuItem` should notify the application through an event or `Action<T>`.

Expected idea:

```text
MenuItem
has title
has submenu items
has Selected event or Action callback

When a leaf item is selected:
MenuItem raises Selected
Ex04.Menus.Test handles the event and runs the matching method
```

Possible class names:

```text
MainMenu
MenuItem
```

The event raiser method should follow the course naming convention, such as `OnSelected`.

## Project Responsibility Split

### Ex04.Menus.Interfaces

Expected responsibilities:

- represent menu items
- represent a main menu
- store menu hierarchy
- display menu levels
- read and validate menu choices
- navigate into submenus
- handle Back/Exit
- activate leaf actions through an interface

### Ex04.Menus.Events

Expected responsibilities:

- represent menu items
- represent a main menu
- store menu hierarchy
- display menu levels
- read and validate menu choices
- navigate into submenus
- handle Back/Exit
- activate leaf actions through events/delegates/`Action<T>`

### Ex04.Menus.Test

Expected responsibilities:

- build the required two demonstration menus
- connect action items to test methods
- implement interface handlers for the interface version
- subscribe event handlers for the event version
- provide the action methods that print date, time, version, and capital counts

## Course Material Rule

All code must stay within the material taught in the course slides and exercise documents.

Use only concepts that appear in the provided course material:

```text
DN_2026B_Ex04.pdf
CodingStandards_NoSC (2).pdf
01 - The .NET Framework.color.pdf
02 - CSharp (basics).color.pdf
03 - CSharp_Classes.color.pdf
04 - CSharp (Reference Types).color.pdf
05 - CSharp (Arrays, Collections).color.pdf
06 - CSharp (Inheritance).color.pdf
07 - CSharp (Polymorphism).color.pdf
code examples for interfaces, callbacks, delegates, and events
```

Prefer simple, explicit, course-style C#.

## Local Rule Documents

Use these files while working:

- [AGENT_CONTEXT.md](AGENT_CONTEXT.md)
- [Coding_Standards.md](Coding_Standards.md)
- [Submission_Rules.md](Submission_Rules.md)
- [Visual_Studio_Workflow.md](Visual_Studio_Workflow.md)
- [Assistant_Guardrails.md](Assistant_Guardrails.md)
- [CodingStandards_NoSC (2).pdf](CodingStandards_NoSC%20%282%29.pdf)

The assignment PDF and coding standards PDF are the source of truth. The Markdown files are working summaries to keep implementation consistent.

## Important Non-Submission Rule

This `Docs` folder, the course presentations folder, the code examples folder, and the extracted PDF text are local reference material only.

They must not be:

- added to the Visual Studio solution
- added to any project file
- copied to output
- referenced from code
- included in the final submission zip unless the lecturer explicitly requires them

## Working Rule

Implement the project gradually. Before writing each meaningful piece of code, check that it fits:

- the Exercise 4 assignment requirements
- the three-project architecture
- the two required menu techniques
- the course coding standards
- the course slides and examples already provided
