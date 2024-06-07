using Mammoth;

namespace TetelBank.Model
{
    public class FileReader
    {
        public string RetHtml(string? path)
        {
            if(path == null)
            {
                return "";
            }
            var converter = new DocumentConverter();
            var result = converter.ConvertToHtml(path);
            var html = result.Value;
            html = html.Replace(@"\", @"\\");
            return html;
        }
    }
}
