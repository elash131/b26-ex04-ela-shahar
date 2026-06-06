# Visual Studio Workflow

This is the Visual Studio workflow for Exercise 4.

## Approved Environment

- Use `Visual Studio for Windows`.
- Keep the project in classic C#/.NET Framework style unless the lecturer says otherwise.
- Build and run from the `.sln` file.

## Required Solution Structure

The solution must contain:

```text
Ex04.Menus.Interfaces
Ex04.Menus.Events
Ex04.Menus.Test
```

`Ex04.Menus.Interfaces`:

- output type: `Class Library`
- produces `Ex04.Menus.Interfaces.dll`
- contains the menu implementation that uses interfaces

`Ex04.Menus.Events`:

- output type: `Class Library`
- produces `Ex04.Menus.Events.dll`
- contains the menu implementation that uses delegates/events/`Action<T>`

`Ex04.Menus.Test`:

- output type: console executable
- produces `Ex04.Menus.Test.exe`
- builds and runs the demonstration menus
- references both menu libraries

## Creating Or Fixing The Projects

If the projects are missing from the solution:

1. Right-click the solution.
2. Choose `Add`.
3. Choose `Existing Project...`.
4. Add `Ex04.Menus.Interfaces\Ex04.Menus.Interfaces.csproj`.
5. Add `Ex04.Menus.Events\Ex04.Menus.Events.csproj`.
6. Add `Ex04.Menus.Test\Ex04.Menus.Test.csproj`.

If the test project does not reference the libraries:

1. Right-click `Ex04.Menus.Test`.
2. Choose `Add`.
3. Choose `Project Reference...`.
4. Check `Ex04.Menus.Interfaces`.
5. Check `Ex04.Menus.Events`.
6. Confirm.

## Startup Project

Set the startup project to:

```text
Ex04.Menus.Test
```

Do not run `Ex04.Menus.Interfaces` or `Ex04.Menus.Events` directly. They are class libraries.

## Adding Existing Files

When adding source files manually on disk, Visual Studio may not show them immediately in old-style `.csproj` projects.

Use one of these options:

- right-click the project and choose `Reload Project`
- unload and reload the project
- add the file through Visual Studio
- verify that the `.csproj` contains the required `Compile Include` entries

## Local Project Name Check

Before final submission, check whether the interface project is accidentally named:

```text
Ex04.Menus.Interaces
```

If so, rename it to:

```text
Ex04.Menus.Interfaces
```

The assignment spelling includes the `f` in `Interfaces`.

## Reference Material Rule

The following folders are not part of the Visual Studio solution:

```text
DN_2026B_Ex04\Docs
DN_2026B_Ex04\מצגות
DN_2026B_Ex04\דוגמאות קוד
```

Do not add them to the solution. Do not link them into the project. They are local guidance only.

## Pre-Work Check

Before implementing code, confirm:

- all three projects appear in Solution Explorer
- `Ex04.Menus.Interfaces` builds as a class library
- `Ex04.Menus.Events` builds as a class library
- `Ex04.Menus.Test` references both libraries
- `Ex04.Menus.Test` is the startup project
- no reference docs are visible as solution/project items
