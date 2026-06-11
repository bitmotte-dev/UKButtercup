using System.IO;
using System.Reflection;

namespace ModTechnicalName;
static class EmbeddedAccess
{
    public static byte[] AccessFile(string fileName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        byte[] bytes;
        using (Stream resFilestream = assembly.GetManifestResourceStream($"ModTechnicalName.resources.{fileName}"))
        {
            if (resFilestream == null)
            {
                return null;
            }

            bytes = new byte[resFilestream.Length];
            resFilestream.Read(bytes, 0, bytes.Length);
        }
        return bytes;
    }

    public static Stream AccessFileStream(string fileName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Stream resFilestream = assembly.GetManifestResourceStream($"ModTechnicalName.resources.{fileName}");
        if (resFilestream == null)
        {
            return null;
        }
        return resFilestream;
    }
}