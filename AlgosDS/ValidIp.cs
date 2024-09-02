// ----------------------------------------------------------------------------
// ValidIp.cs
// ----------------------------------------------------------------------------
namespace AlgosDS.LeetCode
{
    public static class ValidIp {
        public static string ValidIPAddress(string queryIP) {
            if (string.IsNullOrWhiteSpace(queryIP)) {
                return "Neither";
            }
            string ipV4Result = IsValidIpV4(queryIP);
            if (!"Neither".Equals(ipV4Result)) {
                return ipV4Result;
            }
            string ipV6Result = IsValidIpV6(queryIP);
            if (!"Neither".Equals(ipV6Result)) {
                return ipV6Result;
            }
            return "Neither";
        }

        private static string IsValidIpV4(string queryIP) {
            string[] components = queryIP.Split(".");
            if (components.Length == 4) {
                for (int i = 0; i < 4; i++) {
                    string octet = components[i];
                    if (string.IsNullOrWhiteSpace(octet)
                        || (octet.Length > 1 && octet[0] == '0')
                        || octet.Length > 3
                        || !int.TryParse(octet, out int octetValue)) {
                        return "Neither";
                    }
                    else if (octetValue < 0 || octetValue > 255) {
                        return "Neither";
                    }
                }
            }
            else {
                return "Neither";
            }
            return "IPv4";
        }

        private static string IsValidIpV6(string queryIP) {
            HashSet<char> ipV6Characters = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F'];
            string[] components = queryIP.Split(":");
            if (components.Length == 8) {
                for (int i = 0; i < 8; i++) {
                    string quartet = components[i];
                    if (quartet.Length > 4 || quartet.Length < 1) {
                        return "Neither";
                    }
                    foreach (char c in quartet) {
                        if (!ipV6Characters.Contains(c)) {
                            return "Neither";
                        }
                    }
                }
            }
            else {
                return "Neither";
            }
            return "IPv6";
        }
    }
}
