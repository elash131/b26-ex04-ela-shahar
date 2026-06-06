# Coding Standards

This document turns the lecturer coding standards into direct working rules for Exercise 4.

The source of truth is still `CodingStandards_NoSC (2).pdf`. This Markdown file is a working summary.

## Exercise 4 Scope Rule

These standards apply to all source code in:

```text
Ex04.Menus.Interfaces
Ex04.Menus.Events
Ex04.Menus.Test
```

The implementation must stay within the course material supplied in the assignment folder:

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

Prefer simple C# syntax and course-style object-oriented code. Do not use advanced language features, external libraries, or frameworks that are outside the current course material unless the user explicitly approves it.

## Project Separation Rule

`Ex04.Menus.Interfaces` contains the reusable menu implementation based on interfaces.

`Ex04.Menus.Events` contains the reusable menu implementation based on delegates/events/`Action<T>`.

`Ex04.Menus.Test` contains the console demonstration app that builds both required menus and supplies the action methods.

The two menu libraries may use `Console` because the exercise asks for console-menu components.

`Ex04.Menus.Test` may reference both libraries. The libraries must not reference `Ex04.Menus.Test`.

Reference material folders such as `Docs`, `מצגות`, and `דוגמאות קוד` must not be added to the solution or project files.

## Variables And Class Members

### Local Variables

- Use meaningful names, even if they are long.
- Use `camelCase`.
- Indices with no special meaning may be named `i`, `j`, and similar when that is the natural choice.
- Avoid meaningless short names unless they are natural loop/index variables.

Examples:

- Good: `numOfItems`
- Bad: `NumOfItems`
- Bad: `numOfItems_`
- Bad: `NUMOFITEMS`

### Local Const Booleans

This rule applies only to local `const bool` values, not to every local `bool` variable.

- Name local `const bool` values with the prefix `v_`.
- Use CamelCase after the prefix.
- Use them instead of raw `true` / `false` literals when passing boolean parameters to methods.
- They should always be declared as `true`; pass `!v_Name` when the negative value is needed.
- Regular local boolean variables still use normal lower camelCase, such as `shouldContinue` or `isMoveValid`.

Example:

```csharp
const bool v_IsMainMenu = true;
```

### Class And Struct Members

- Regular data members: `m_SomeName`
- Const members and local consts: `k_SomeName`
- Static members: `s_SomeName`
- Readonly members: `r_SomeName`
- Static readonly members: `sr_SomeName`

## Statements

- Always wrap `if`, `else`, `for`, `while`, and similar bodies with curly braces.
- Do not rely on single-line statement bodies without braces.

## Properties, Methods, And Indexers

### Naming

- Use meaningful names.
- Do not add underscores to method names.
- Use PascalCase for public and protected methods.
- Private methods should start with a lower-case first letter.

Examples:

- Good: `GetNumOfItems`
- Good private method: `getNumOfItems`
- Bad: `get_num_of_items`
- Bad: `GetnumofItems`
- Bad: `GETNUMOFITEMS`

### Method Declaration

- Use spaces between parameter declarations, not tabs.
- Keep the method declaration on one line when reasonable.
- If there are many parameters, split the parameter list across several lines.

### Parameters

- Use meaningful parameter names.
- Prefix parameters by direction:
- `i_` = input only
- `o_` = output only
- `io_` = input and output

Examples:

- `string i_Title`
- `MenuItem i_MenuItem`
- `out int o_UserChoice`
- `ref bool io_ShouldContinue`

## Classes And Structs

- Use meaningful names.
- Use PascalCase.

Exercise 4 likely needs classes such as:

```text
MainMenu
MenuItem
```

## Interfaces

- Use meaningful names.
- Use PascalCase.
- Public interfaces used by another project must be visible outside the library.
- Prefer names that describe the role of the object.

Possible Exercise 4 interface names:

```text
IMenuItemSelectedObserver
IMenuItemAction
```

Choose one clear style and keep it consistent.

## Enums

- Use meaningful names.
- Use PascalCase.
- Prefix enum type names with `e`.
- For flagged enums, use a plural name ending with `s`.
- Do not use C++-style enum naming.
- Do not use unnecessary underscores.

Examples:

- Good: `eMenuNavigationResult`
- Bad: `Menu_Navigation_Result`

## Delegates And Events

### Delegates

- Use meaningful names.
- Delegate names follow class naming style.
- End regular delegate names with `Delegate`.
- If the delegate is an event handler, use the suffix `EventHandler`, not `Delegate`.

### Events

- Event names should be PascalCase.
- Event names should describe the event clearly.

Examples:

```text
Selected
ItemSelected
```

### Event Handler Methods In Subscribers

Name them as `<senderName>_<EventName>` when practical.

Example:

```csharp
showVersionMenuItem_Selected(object sender, EventArgs e)
```

If using `Action<MenuItem>` instead of the classic `EventHandler` pattern, still keep method names clear and event-like.

### Event Raiser Methods

The internal method that raises an event should be named `OnXXX`.

Example:

```csharp
OnSelected(EventArgs e)
```

## Style

### Conditions

Prefer direct boolean assignment.

Good:

```csharp
hasSubMenuItems = m_SubMenuItems.Count > 0;
```

Bad:

```csharp
if(m_SubMenuItems.Count > 0)
{
	hasSubMenuItems = true;
}
else
{
	hasSubMenuItems = false;
}
```

### Duplicated Code

- Do not duplicate shared code inside both `if` and `else`.
- Move shared code outside the branch when possible.
- Duplicated code between `Ex04.Menus.Interfaces` and `Ex04.Menus.Events` is allowed by the assignment because they are separate implementations.

### Layout

- Use tabs, not spaces, for indentation.
- Each nested block should be indented one tab deeper than its parent block.

### Spaces

- Do not use double blank lines.
- Do not leave redundant blank lines.
- Use spaces around operators.
- Use spaces after commas in parameter lists and argument lists.
- Do not put a space before method-call parentheses.
- Preserve one consistent control-statement spacing style within the file/repository.

Good:

- `x = t + 5;`
- `if(x == 5)`
- `Console.WriteLine("Hello {0} and {1}", name1, name2);`
- `DoSomeThing(5, 4);`

Bad:

- `x=t+5;`
- `if(x==5)`
- `Console.WriteLine("Hello {0} and {1}",name1,name2);`
- `DoSomeThing (5, 4);`

### Blank Lines

- Add a blank line after the local variable declarations section.
- Add a blank line after a closing brace, unless another closing brace or `else` follows immediately.
- Add a blank line before the single return statement.

## Method Implementations

- Use only one `return` statement per method when reasonable.
- Prefer methods that implement a flow by calling other methods instead of one long monolithic implementation.

## Safe Working Summary

When in doubt, prefer:

- meaningful names
- explicit braces
- clear method flow
- one return
- no unnecessary advanced syntax
- no accidental Exercise 3 terms
- tabs for indentation
- exact naming conventions
