# EX4 — Grading Checklist (Based on Lecturer's Report)

> Extracted from the official grading report. Each item maps to a lecturer code (e.g. `DSN-001`).
> Items marked `no` in the reference submission lost points — pay extra attention to those.

---

## 1. Functionality (25% of grade)

| # | Criterion | Code | ✅ |
|---|---|---|---|
| 1 | The demo program runs | SFN-001 | [ ] |
| 2 | Test uses both projects and shows menus with sub-menus in both implementations | SFN-002 | [ ] |
| 3 | Items and sub-items can be added to any menu | SFN-003 | [ ] |
| 4 | Each menu has a title and a Back / Exit option | SFN-004 | [ ] |
| 5 | Navigation between menus works; leaf items trigger actions (not sub-menus) | SFN-005 | [ ] |
| 6 | The menu project manages input by itself | SFN-006 | [ ] |
| 7 | Both required implementations were submitted | SFN-007 | [ ] |
| 8 | The menu project includes a class that enables building a menu hierarchy | SFN-008 | [ ] |

---

## 2. Design (45% of grade) ⚠️ Most important section

| # | Criterion | Code | ✅ | Note |
|---|---|---|---|---|
| 1 | Logical class division | DSN-001 | [ ] | **Friends lost -5 here** — wrong structure |
| 2 | Separation between logic and UI | DSN-002 | [ ] | |
| 3 | Proper method decomposition | DSN-003 | [ ] | |
| 4 | No code duplication | DSN-004 | [ ] | |
| 5 | Exceptions used where needed | DSN-005 | [ ] | |
| 6 | Correct use of delegates | DSN-006 | [ ] | |
| 7 | Correct use of interfaces | DSN-007 | [ ] | |
| 8 | Correct use of OOP principles | DSN-008 | [ ] | |

> **DSN-001 detail:** The correct structure is: `Menu` (abstract) holds a list of `MenuItem`. `MenuItem` derives from `Menu`. Do NOT put everything in one class.

---

## 3. Coding Standards (10% of grade)

### Naming
| # | Criterion | Code | ✅ |
|---|---|---|---|
| 0 | Variable names are meaningful | CSS-000 | [ ] |
| 1 | Regular local variables: `camelCase` | CSS-001 | [ ] |
| 2 | Class fields: `m_PascalCase` | CSS-002 | [ ] |
| 3 | Constants: `k_PascalCase` | CSS-003 | [ ] |
| 4 | Static fields: `s_PascalCase` | CSS-004 | [ ] |
| 10 | Private method names: `camelCase` | CSS-010 | [ ] |
| 11 | Public method names: `PascalCase` | CSS-011 | [ ] |
| 12 | Property names: `PascalCase` | CSS-012 | [ ] |
| 13 | Input parameters prefixed `i_` | CSS-013 | [ ] |
| 14 | Output parameters prefixed `o_` | CSS-014 | [ ] |
| 15 | Ref parameters prefixed `io_` | CSS-015 | [ ] |
| 16 | Class names: `PascalCase` | CSS-016 | [ ] |
| 17 | Main class named `Program` | CSS-017 | [ ] |
| 21 | Event/delegate names follow convention (`OnXXX`, `XXXDelegate`, `XXXEventHandler`) | CSS-021 | [ ] | **Friends lost -2 here** |

### Structure
| # | Criterion | Code | ✅ |
|---|---|---|---|
| 5 | `if` statements written correctly (always with braces) | CSS-005 | [ ] |
| 6 | Blank line after `if` / `else` blocks | CSS-006 | [ ] |
| 7 | Space after `;` in `for` loops | CSS-007 | [ ] | **Friends lost points here** |
| 8 | Blank line after `while` loops | CSS-008 | [ ] |
| 9 | Space after every comma in parameters | CSS-009 | [ ] |
| 25 | Spaces around operators | CSS-025 | [ ] |
| 26 | TAB indentation for each new block | CSS-026 | [ ] |
| 27 | Blank lines in correct places | CSS-027 | [ ] |
| 28 | Only ONE `return` per method | CSS-028 | [ ] |

---

## 4. .NET Technologies (15% of grade)

| # | Criterion | Code | ✅ | Note |
|---|---|---|---|---|
| 1 | Use `string.Format` where appropriate | NTT-001 | [ ] | |
| 2 | Use `int.TryParse` for input validation | NTT-002 | [ ] | |
| 3 | Correct use of Exceptions | NTT-003 | [ ] | |
| 4 | Use `string` methods where appropriate | NTT-004 | [ ] | |
| 5 | Correct use of Properties | NTT-005 | [ ] | |
| 7 | Correct use of collections and data structures | NTT-007 | [ ] | |
| 8 | Correct use of delegates | NTT-008 | [ ] | |
| 999 | Use `Environment.NewLine` instead of `"\n"` | NTT-999 | [ ] | **Friends lost -3 here** |

---

## 5. Submission Rules (5% of grade)

| # | Criterion | Code | ✅ |
|---|---|---|---|
| 1 | Email subject formatted correctly | RUL-001 | [ ] |
| 2 | Submission report written in email body | RUL-002 | [ ] |
| 3 | Report attached to solution | RUL-003 | [ ] |
| 4 | ZIP file name and inner folder name formatted correctly | RUL-004 | [ ] |
| 5 | ZIP contains one folder with `.sln` and project folders inside | RUL-005 | [ ] |
| 6 | Submitted on time | RUL-006 | [ ] |

---

## Key Mistakes from Reference Submission (avoid these)

| Issue | Points Lost | Code |
|---|---|---|
| Wrong class structure — everything in one class instead of `Menu` + `MenuItem` hierarchy | -5 | DSN-001 |
| Event raiser not named `OnXXX` | -2 | CSS-021 |
| Used `"\n"` instead of `Environment.NewLine` | -3 | NTT-999 |
| **Total lost** | **-10** | |
