using Microsoft.AspNetCore.Mvc.RazorPages;
using Markdig;

namespace exh_cli_cmd.Pages
{
    public class MarkdownPageModel : PageModel
    {
        private readonly ILogger<MarkdownPageModel> _logger;
        public string RenderedMarkdown { get; private set; }

        public MarkdownPageModel(ILogger<MarkdownPageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string markdownContext = System.IO.File.ReadAllText("../MASTER_COMMANDS.md");
            this.RenderedMarkdown = Markdown.ToHtml(markdownContext);
        }
    }
}
