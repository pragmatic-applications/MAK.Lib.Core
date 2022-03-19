namespace Extensions;

public static class JwtParser
{
    public static IEnumerable<Claim> ParseClaimsFromJwt(this string jwt)
    {
        var claims = new List<Claim>();
        var payload = jwt.Split('.')[1];

        var jsonBytes = ParseBase64WithoutPadding(payload);

        var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

        ExtractRolesFromJWT(claims, keyValuePairs);

        claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

        return claims;
    }

    private static void ExtractRolesFromJWT(this List<Claim> claims, Dictionary<string, object> keyValuePairs)
    {
        keyValuePairs.TryGetValue(ClaimTypes.Role, out var roles);

        if(roles != null)
        {
            var parsedRoles = roles.ToString().Trim().Split(',');

            if(parsedRoles.Length > 1)
            {
                foreach(var parsedRole in parsedRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                }
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, parsedRoles[0]));
            }

            keyValuePairs.Remove(ClaimTypes.Role);
        }
    }

    private static byte[] ParseBase64WithoutPadding(this string base64)
    {
        switch(base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }
        return Convert.FromBase64String(base64);
    }
}
