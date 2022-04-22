using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
namespace ChangePermissions
{
    internal class Program
    {
        // Add <requestedExecutionLevel level="requireAdministrator" uiAccess="false" /> to the app.manifest
        private static void GetAccess(string name)
        {
            FileInfo info = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), name));
            FileSecurity security = info.GetAccessControl();
            security.AddAccessRule(new FileSystemAccessRule(
                new SecurityIdentifier(WellKnownSidType.WorldSid, null), 
                FileSystemRights.FullControl, AccessControlType.Allow));
            info.SetAccessControl(security);
        }
        static void Main(string[] args)
        {
            GetAccess("DatabasePOSDatabase.mdf");
            GetAccess("DatabasePOSDatabase_log.ldf");
        }
    }
}
