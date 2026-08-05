# Desktop template (WinForms)

A WinForms app with the logic split out so it can be tested headlessly.

Shape: **desktop**. Onboarding adds `test.yml` running on **windows-latest** and
`manifest.yml`. Deliberately no `run-capture.yml` — `dotnet run` on a WinForms
app opens a window and hangs a headless runner.

## Why the layout is exactly this

- **`<UseWindowsForms>true</UseWindowsForms>`** is the routing signal. Without
  it the repo resolves to `console`, and `dotnet build` fails on ubuntu because
  the Windows Desktop targeting packs are Windows-only.
- **Logic outside the Form.** `Greeter` holds the testable behavior; CI cannot
  instantiate a `Form`, so anything worth testing must live outside one.
- **The form is built in code**, not a `.Designer.cs`. Easier to read in a diff.
  Switch to the designer if you prefer — nothing in the pipeline cares.

Runs on windows-latest, which is slower and costs more Actions minutes than the
console shape.

Pages source: `main`, root (source manifest only).
