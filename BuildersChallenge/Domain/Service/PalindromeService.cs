using BuildersChallenge.Domain.ServicesInterface;
using System;
using System.Linq;

namespace BuildersChallenge.Domain.Service
{
    public class PalindromeService : IPalindromeService
    {
        public Palindrome IsPalindom(string text)
        {
            var palin = new Palindrome();
            palin.Origin = text;
            palin.Reversed = new string(palin.Origin.Reverse().ToArray());
            palin.IsPalindrom = palin.Origin == palin.Reversed;
            return palin;
        }
    }
}
