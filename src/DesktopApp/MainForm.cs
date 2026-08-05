namespace DesktopApp;

/// <summary>
/// Built in code rather than with a .Designer.cs file so the form is readable
/// in a diff and on a phone. Add the designer back if you prefer the visual
/// editor — nothing in the pipeline depends on either style.
/// </summary>
public class MainForm : Form
{
    private readonly TextBox _input;
    private readonly Label _output;

    public MainForm()
    {
        Text = "Desktop template";
        Width = 420;
        Height = 200;
        StartPosition = FormStartPosition.CenterScreen;

        _input = new TextBox { Left = 20, Top = 25, Width = 250 };

        Button go = new Button { Text = "Greet", Left = 285, Top = 23, Width = 90 };
        go.Click += OnGreetClicked;

        _output = new Label { Left = 20, Top = 75, Width = 355, Text = string.Empty };

        Controls.Add(_input);
        Controls.Add(go);
        Controls.Add(_output);
    }

    private void OnGreetClicked(object? sender, EventArgs e)
    {
        _output.Text = Greeter.Greet(_input.Text);
    }
}
