namespace DesktopApp;

/// <summary>
/// The logic lives outside the Form so it can be tested without opening a
/// window — headless CI cannot instantiate a Form.
/// </summary>
public static class Greeter
{
    public static string Greet(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello, world.";
        }

        return $"Hello, {name.Trim()}.";
    }
}
