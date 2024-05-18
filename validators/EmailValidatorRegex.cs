using System.Text.RegularExpressions;
using yt_benchmark.interfaces;

namespace yt_benchmark.validators;

public class EmailValidatorRegex : IEmailValidator
{
    static Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

    public bool IsValid(string email)
    {
        //regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        return regex.Match(email).Success;        
    }
}
