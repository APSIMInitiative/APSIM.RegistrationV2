
namespace APSIM.RegistrationV2.Components.Classes.Registration.EventArgs;

public class StringEventArgs(string? value) : System.EventArgs
{
    public string? Value { get; set; } = value;
}