# Assistant Guardrails

These are the working rules I should treat as binding when helping on this Exercise 4 project.

## Highest Priority Rules

1. Always answer the user in English.
2. Keep `Docs`, course presentations, code examples, and extracted PDF text outside the solution and outside all project files.
3. Do not add references to local guidance material from submitted code.
4. Follow the Exercise 4 PDF and the course coding standards.
5. Use only material that appears in the course slides/documents/examples unless the user explicitly approves otherwise.
6. Do not invent project names or submission structure when the exercise already defines them.
7. Do not leave generated folders in the final hand-in.
8. Work incrementally and explain architecture before large implementation changes when the user asks for understanding.

## Course Material Boundary

The implementation should use only concepts from:

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

Avoid advanced or newer C# features that may not be part of the course material, including unnecessary LINQ-heavy solutions, reflection, async/await, external libraries, dependency injection frameworks, records, pattern matching-heavy code, or other concepts not covered by the slides.

Prefer simple, explicit, course-style C#.

## Coding Guardrails

- Use the lecturer naming conventions exactly.
- Use braces for statement bodies.
- Use tabs for indentation.
- Keep one return statement per method when implementing course-style solutions.
- Avoid duplicated code inside each project.
- Keep method and type names meaningful and consistent with the standards.
- Respect parameter prefixes: `i_`, `o_`, `io_`.
- Respect member prefixes: `m_`, `k_`, `s_`, `r_`, `sr_`.
- Respect enum prefix `e`.
- Use `v_` only for local `const bool` values used instead of raw `true` / `false` method arguments.
- Regular local boolean variables use normal lower camelCase.
- For events, use meaningful PascalCase names and `OnXXX` event raiser methods.
- Event handler methods in subscribers should follow `<senderName>_<EventName>` when practical.

## Architecture Guardrails

- `Ex04.Menus.Interfaces` is the reusable menu library implemented with interfaces.
- `Ex04.Menus.Events` is the reusable menu library implemented with delegates/events/`Action<T>`.
- `Ex04.Menus.Test` is the console executable that demonstrates both libraries.
- `Ex04.Menus.Test` may reference both libraries.
- The library projects must not reference `Ex04.Menus.Test`.
- The library projects should normally not reference each other.
- Both libraries may use `Console` because they are console-menu components.
- Keep the two implementations separate even if some code is similar. The assignment explicitly allows similar code between the two first projects.

## Menu Model Guardrails

The shared conceptual model is:

```text
MainMenu
has root MenuItem

MenuItem
has title
has child MenuItem collection
optionally activates an action when selected
```

Navigation behavior:

- main menu uses `0. Exit`
- submenu uses `0. Back`
- leaf item activates an action
- non-leaf item navigates into a submenu
- after an action, return to the current menu level
- invalid input should not crash the program

## Interface Implementation Guardrails

The interface-based project should let `Ex04.Menus.Test` connect actions through an interface.

Important questions to preserve in the design:

- What public interface does the menu library expose?
- Who implements the interface?
- Which menu item holds the interface implementer?
- Which method is called when a leaf menu item is selected?

The interface must be visible to `Ex04.Menus.Test`.

## Events Implementation Guardrails

The event-based project should let `Ex04.Menus.Test` connect actions through events, delegates, or `Action<T>`.

Important questions to preserve in the design:

- Which object owns the event or action callback?
- Who subscribes to it?
- Who raises it?
- What data, if any, is passed to the handler?

Use `OnXXX` for event raising methods.

## Solution Structure Guardrails

- Keep the solution compatible with Visual Studio for Windows.
- Keep the solution with three projects: `Ex04.Menus.Interfaces`, `Ex04.Menus.Events`, and `Ex04.Menus.Test`.
- `Ex04.Menus.Interfaces` must have `OutputType` set to `Library`.
- `Ex04.Menus.Events` must have `OutputType` set to `Library`.
- `Ex04.Menus.Test` must be the startup project when running the program.

## Submission Guardrails

- Treat naming formats as exact, not approximate.
- Remove `bin`, `obj`, `.git`, `.vs`, and `packages` before final packaging unless the lecturer says otherwise.
- Keep the zip structure clean and predictable.
- Do not include local reference docs, extracted text, code examples, or course slides in the final submission unless explicitly required.
- Do not leave Exercise 3 names or garage/vehicle artifacts in the solution.

## Review Guardrails

Before saying a submission is ready, verify:

- naming
- folder cleanliness
- Visual Studio compatibility
- project references
- startup project
- coding style compliance
- required menu behavior
- final zip readiness
- no accidental references to `Docs`, presentations, examples, or extracted PDF text

If any of those fail, the work is not submission-ready yet.
