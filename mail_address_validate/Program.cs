using System.Net.Mail;

static bool IsValidEmail(string email)
{
    try
    {
        MailAddress mailAddress = new MailAddress(email);
        return true;
    }
    catch (FormatException)
    {
        return false;
    }
}


string email = "oguzalparsln@icloud.com";
bool isValid = IsValidEmail(email);
if (isValid)
{
    Console.WriteLine("E-posta adresi geçerli.");
    Console.WriteLine("E-posta : " + email);
}
else
{
    Console.WriteLine("E-posta adresi ({0}) geçerli değil.", email);
}
