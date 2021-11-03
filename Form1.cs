using System;
using GemBox.Document;
using System.Windows.Forms;
using GemBox.Document.Tables;
using System.IO;

namespace TableCopyFontChangeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComponentInfo.SetLicense("DN-2021Oct22-2021Nov22-IKv0l6Cc/injEfaOK9dy3BDhApSixqELXlaLb0BP5yj6sNr5bACjU1Q6r2sQtnqdaQi7KAvM67ChNHLBpzU0gbySB1g==B");
        }

        private void btRunTest_Click(object sender, EventArgs e)
        {
            DocumentModel sourcedoc = DocumentModel.Load("SourceDoc.docx");
            DocumentModel targetdoc = DocumentModel.Load("TargetDoc.docx");

            foreach (Table xtable in sourcedoc.GetChildElements(true, ElementType.Table))
            {
                string rowdata = xtable.Rows[0].Content.ToString();

                if (rowdata.IndexOf("FINDINGS") >= 0 || rowdata.IndexOf("Findings") >= 0)
                {
                    var TEMP_Doc = new DocumentModel();
                    TEMP_Doc.Content.End.InsertRange(xtable.Content);
                    targetdoc.Bookmarks["FFindings"].GetContent(true).Set(TEMP_Doc.Sections[0].Blocks.Content);
                }
                if (rowdata.IndexOf("Reasoning") >= 0)
                {
                    var TEMP_Doc = new DocumentModel();
                    TEMP_Doc.Content.End.InsertRange(xtable.Content);
                    targetdoc.Bookmarks["FReasoning"].GetContent(true).Set(TEMP_Doc.Sections[0].Blocks.Content);
                }
                if (rowdata.IndexOf("Legal") >= 0)
                {
                    var TEMP_Doc = new DocumentModel();
                    TEMP_Doc.Content.End.InsertRange(xtable.Content);
                    targetdoc.Bookmarks["FLegal"].GetContent(true).Set(TEMP_Doc.Sections[0].Blocks.Content);
                }
            }
            File.Delete("TargetDocUpdated.docx");
            targetdoc.Save("TargetDocUpdated.docx");
            System.Diagnostics.Process.Start("TargetDocUpdated.docx");

            this.Close();
        }
    }
}
