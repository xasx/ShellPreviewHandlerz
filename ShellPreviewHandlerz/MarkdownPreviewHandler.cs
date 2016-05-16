using SharpShell.Attributes;
using SharpShell.SharpPreviewHandler;
using System;
using System.Runtime.InteropServices;

namespace ShellPreviewHandlerz
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.ClassOfExtension, ".md")]
    [DisplayName("Markdown Preview Handler")]
    [PreviewHandler()]
    public class MarkdownPreviewHandler : SharpPreviewHandler
    {
        protected override PreviewHandlerControl DoPreview()
        {
            HTMLPreviewControl control = new HTMLPreviewControl();

            if (!String.IsNullOrEmpty(SelectedFilePath))
            {
                using (var reader = new System.IO.StreamReader(SelectedFilePath))
                {
                    string content = reader.ReadToEnd();
                    string result = CommonMark.CommonMarkConverter.Convert(content);
                    control.Input = result;
                }
                
            } else
            {
                control.Input = "<i>No file selected</i>";
            }

            return control;
        }
    }
}
