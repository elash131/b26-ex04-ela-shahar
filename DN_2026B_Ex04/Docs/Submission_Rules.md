# Submission Rules

This document captures the submission rules relevant to Exercise 4.

## Core Submission Expectations

- Submit a Visual Studio solution that opens cleanly in Visual Studio for Windows.
- The solution must contain `Ex04.Menus.Interfaces`, `Ex04.Menus.Events`, and `Ex04.Menus.Test`.
- `Ex04.Menus.Interfaces` must be a class library that produces a `.dll`.
- `Ex04.Menus.Events` must be a class library that produces a `.dll`.
- `Ex04.Menus.Test` must be a console executable that produces an `.exe`.
- `Ex04.Menus.Test` must reference both menu libraries.
- Follow the course coding standards.
- Keep the code simple and aligned with the course slides.

## Required Exercise 4 Files

The final submission folder should include the Visual Studio solution and the three project folders:

```text
Ex04 Ela 318481066 Shahar 207108846.sln
Ex04.Menus.Interfaces\
Ex04.Menus.Events\
Ex04.Menus.Test\
```

Check the exact final solution/folder naming against the lecturer submission instructions before packaging.

## Files That Should Not Be Part Of The Solution

The local reference folders must not be added to the solution or projects:

```text
DN_2026B_Ex04\Docs
DN_2026B_Ex04\מצגות
DN_2026B_Ex04\דוגמאות קוד
```

They are not source files, not content files, and not submission artifacts unless the lecturer explicitly requests them.

## Generated Folders To Remove Before Submission

Delete these folders before creating the final zip:

```text
bin
obj
.git
.vs
packages
```

Do not delete source files, the `.sln`, or the `.csproj` files.

## Startup Project

Set the startup project to:

```text
Ex04.Menus.Test
```

The two library projects are not runnable applications.

## Required References

`Ex04.Menus.Test` should reference:

```text
Ex04.Menus.Interfaces
Ex04.Menus.Events
```

The two library projects should not reference `Ex04.Menus.Test`.

The two library projects should normally not reference each other. They are separate implementations of the same menu idea.

## Functional Checklist

Before submission, verify that:

- The solution opens in Visual Studio for Windows.
- The solution builds.
- `Ex04.Menus.Test` is the startup project.
- `Ex04.Menus.Interfaces` builds as a `.dll`.
- `Ex04.Menus.Events` builds as a `.dll`.
- `Ex04.Menus.Test` builds as an `.exe`.
- `Ex04.Menus.Test` references both class libraries.
- Running the program first shows the interface-based menu.
- After exiting the first menu, the event-based menu is shown.
- Each menu contains the required two top-level items and four leaf actions.
- `0` is shown as `Exit` in the main menu.
- `0` is shown as `Back` in submenus.
- Invalid input is handled without crashing.
- Menu titles are shown in green.
- `Show Version` prints `App Version: 26.2.4.7310`.

## Final Pre-Submission Checklist

- No `bin`, `obj`, `.git`, `.vs`, or `packages`.
- No local `Docs`, presentations, code examples, or extracted PDF text inside the submitted solution.
- No advanced code outside the course material.
- No accidental Exercise 3 names, vehicle classes, garage files, or `VehiclesDB.txt` references.
