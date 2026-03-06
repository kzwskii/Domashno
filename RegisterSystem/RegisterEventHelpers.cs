using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterSystem;

public static class RegisterEventHelpers
{
    public static bool CheckAllFields(string txtUsername, string txtPassword, string txtConfirmPassword)
    {
        return string.IsNullOrWhiteSpace(txtUsername) ||
               string.IsNullOrWhiteSpace(txtPassword) ||
               string.IsNullOrWhiteSpace(txtConfirmPassword);
    }
}
