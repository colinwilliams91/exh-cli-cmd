using Microsoft.AspNetCore.Mvc.RazorPages;
using Markdown.ColorCode;
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
            string markdownContext = System.IO.File.ReadAllText("./MASTER_COMMANDS.md");

            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .UseColorCode()
                .Build();

            this.RenderedMarkdown = Markdig.Markdown.ToHtml(markdownContext, pipeline);
        }
    }
}
