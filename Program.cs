using System;

namespace base64_onedrive_encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Base64 Onedrive Encoder by Japsu {Environment.NewLine}{Environment.NewLine}");
            Console.WriteLine("Please input the shared URL to encode:");
            string url = Console.ReadLine();

            Console.WriteLine();
            float oldTime = DateTime.Now.Millisecond;
            Console.WriteLine($"Started encoding URL: {url}{Environment.NewLine}");

            string sharingUrl = url;
            string base64Value = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(sharingUrl));
            string encodedUrl = "https://api.onedrive.com/v1.0/shares/" + "u!" + base64Value.TrimEnd('=').Replace('/', '_').Replace('+', '-') + "/root/content";

            float currTime = DateTime.Now.Millisecond;
            float activeTime = currTime - oldTime;
            Console.WriteLine($"Done! in {activeTime}ms{Environment.NewLine}");
            Console.WriteLine($"Encoded URL: {encodedUrl}{Environment.NewLine}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
