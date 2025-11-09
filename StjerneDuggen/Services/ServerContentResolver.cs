using System.Reflection.PortableExecutable;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace StjerneDuggen.Services
{
    public static class ServerContentResolver
    {
        public static string ServerUrl { get; private set; } = "https://dakaa16.github.io/Stjerneduggen-image-server";
        
        public static string ManifestFileName { get; private set; } = "manifest.json";

        public static string ImageFolderName { get; private set; } = "images";
        public static string DynamicTextFolderName { get; private set; } = "dynamic-text";

        public static string FallbackImageUrl = "https://dakaa16.github.io/Stjerneduggen-image-server/images/ImageToCome.jpg";

        public static Dictionary<string, List<ManifestFile>> ServerFiles { get; private set; } = new Dictionary<string, List<ManifestFile>>();

        public static string GetImageUrl(string imageName, string folderName = "images")
        {
            try
            {
                return ServerFiles[folderName].Where(f => f.Name.Equals(imageName)).First().Path;
            }
            catch
            {
                return FallbackImageUrl;
            }
        }

        public static List<string> GetImageUrlsFromFolder(string folderName)
        {
            try
            {

                return ServerFiles[folderName].Select(f => f.Path).ToList();
            }
            catch
            {
                return new List<string> { FallbackImageUrl, FallbackImageUrl, FallbackImageUrl };
            }
        }

        //public static async Task<string> GetDynamicText(string fileName)
        //{
        //    try
        //    {
        //        using var http = new HttpClient();

        //        var textFileUrl = ServerFiles[DynamicTextFolderName].Where(f => f.Name.Equals(fileName)).First().Path;

        //        Console.WriteLine($"Fetching text from: {textFileUrl}");
        //        var response = await http.GetAsync(textFileUrl);
        //        response.EnsureSuccessStatusCode();

        //        Console.WriteLine($"Response: {response.StatusCode}");

        //        return await response.Content.ReadAsStringAsync();
        //    }
        //    catch
        //    {
        //        return $"Kunne ikke hente tekst for filen '{fileName}'";
        //    }
        //}

        public static async Task LoadManifestFileAsync()
        {
            using var http = new HttpClient();

            var manifestUrl = AppendToUrl(ServerUrl, ManifestFileName);
            Console.WriteLine($"Fetching manifest from: {manifestUrl}");
            var response = await http.GetAsync(manifestUrl);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var root = JsonSerializer.Deserialize<Dictionary<string, List<ManifestItem>>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
                ?? throw new InvalidOperationException("Failed to deserialize manifest.json");

            if (root == null)
                throw new InvalidOperationException("Failed to deserialize manifest.json");

            var result = new Dictionary<string, List<ManifestFile>>();

            foreach (var (folder, items) in root)
            {
                CollectFiles(items, result, folder);
            }

            ServerFiles = result;
        }

        private static void CollectFiles(IEnumerable<ManifestItem> items, Dictionary<string, List<ManifestFile>> dictionary, string currentFolder)
        {
            dictionary[currentFolder] = new List<ManifestFile>();
            foreach (var item in items)
            {
                if (item.Type == "file" && item.Path != null)
                    dictionary[currentFolder].Add(new ManifestFile(item));
                else if (item.Type == "directory" && item.Children != null)
                    CollectFiles(item.Children, dictionary, item.Name);
            }
        }

        private static string AppendToUrl(string url, string appendage)
        {
            return url + "/" + appendage;
        }

        private static string AppendFileType(string url, string type)
        {
            return url + "." + type;
        }

        public class ManifestItem
        {
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public string? Path { get; set; }
            public List<ManifestItem>? Children { get; set; }
        }

        public class ManifestFile
        {
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public string Path { get; set; }

            public ManifestFile(ManifestItem manifestItem)
            {
                Name = removeFileType(manifestItem.Name);
                Type = manifestItem.Type;
                Path = AppendToUrl(ServerUrl, manifestItem.Path!);
            }

            private string removeFileType(string name)
            {
                var fileTypeDotIndex = name.LastIndexOf('.');
                if (fileTypeDotIndex != -1)
                {
                    return name.Substring(0, fileTypeDotIndex);
                }
                return name;
            }
        }
    }
}
