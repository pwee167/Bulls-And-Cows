﻿
using System;
using System.Text.RegularExpressions;

namespace BullsAndCows.Core
{
    public class Verifier : IVerifier
    {
        public VerificationResult Verify(string code, string guess)
        {
            const RegexOptions regexOptions = RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase;
            var isGuessValid = new Regex("^[0-9]{4}$", regexOptions);

            if (!isGuessValid.IsMatch(guess))
            {
                throw new ArgumentException("Your guess is not in the valid format. It should be contain four unique digits, excluding zero.");
            }

            return new VerificationResult();
        }
    }
}
