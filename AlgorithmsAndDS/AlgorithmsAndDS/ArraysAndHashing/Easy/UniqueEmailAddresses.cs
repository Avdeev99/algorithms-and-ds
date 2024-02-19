namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 929. Unique Email Addresses
public class UniqueEmailAddresses
{
    // Time complexity: O(nm); Space complexity: O(n).
    public int NumUniqueEmails(string[] emails)
    {
        var uniqueEmails = new HashSet<string>();
        
        foreach (var email in emails)
        {
            var parts = email.Split('@');
            var localName = parts[0];
            localName = string.Join(string.Empty, localName.Split('.'));
            localName = localName.Split('+')[0];
            var domainName = parts[1];

            var uniqueEmail = localName + "@" + domainName;
            uniqueEmails.Add(uniqueEmail.ToLower());
        }

        return uniqueEmails.Count;
    }
}