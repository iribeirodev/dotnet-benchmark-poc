using System.Text.RegularExpressions;
using yt_benchmark.interfaces;

namespace yt_benchmark.validators;

public class EmailValidatorRegexCompiled : IEmailValidator
{
    static Regex regex = new Regex(
        @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", 
        RegexOptions.Compiled);

    public bool IsValid(string email)
    {
        //regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        return regex.Match(email).Success;        
    }
}
