using Markdig;
using Microsoft.AspNetCore.Components;

namespace StjerneDuggen.Services
{
    public class MarkdownToHtmlService
    {
        private readonly HttpClient _http;
        private const string markdownFolder = "resources/markdown/";

        public MarkdownToHtmlService(HttpClient http)
        {
            _http = http;
        }

        public async Task<MarkupString> LoadMarkdownAsync(string relativePath)
        {
            try
            {
                relativePath = Path.Combine(markdownFolder, relativePath);
                var markdown = await _http.GetStringAsync(relativePath);
                var html = Markdown.ToHtml(markdown);
                return new MarkupString(html);
            }
            catch (HttpRequestException)
            {
                return new MarkupString($"<p><em>Unable to load file: {relativePath}</em></p>");
            }
        }
    }
}
