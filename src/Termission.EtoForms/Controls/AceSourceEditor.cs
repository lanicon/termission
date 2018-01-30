﻿using System;
using System.Text;
using Eto.Forms;
using Juniansoft.Termission.Core.Resources;

namespace Juniansoft.Termission.EtoForms.Controls
{
    public class AceSourceEditor: WebView
    {
        public AceSourceEditor()
        {
            var js = new StringBuilder();
            js.AppendLine(AppResources.AceJS);
            js.AppendLine(AppResources.AceModeJavascriptJs);
            js.AppendLine(AppResources.AceModeCSharpJs);
            js.AppendLine(AppResources.AceLanguageToolsJS);
            js.AppendLine(AppResources.AceEditorJS);

            var html = new StringBuilder();
            html.AppendLine(AppResources.AceEditorHtml);
            html.Replace("//ace.js", js.ToString());

            this.LoadHtml(html.ToString());

            this.BrowserContextMenuEnabled = false;

        }

        public string Text
        {
            get => this.ExecuteScript("editor.getValue();");

            set => this.ExecuteScript($"editor.setValue(\"{value}\");");
        }
    }
}
