using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiliconSource
{
    internal class PDFExporter
    {
        private string DefaultFileName { get; set; }

        public PDFExporter(string defaultFileName = "Export.pdf")
        {
            DefaultFileName = defaultFileName;
        }

        /// <summary>
        /// Exports the given DataGridView to a PDF file.
        /// </summary>
        public void Export(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = DefaultFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // Add a title
                            Paragraph title = new Paragraph("Exported Data", FontFactory.GetFont("Arial", 16, Font.BOLD));
                            title.Alignment = Element.ALIGN_CENTER;
                            title.SpacingAfter = 20f;
                            pdfDoc.Add(title);

                            // Create PDF table with same number of columns
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.WidthPercentage = 100;

                            // Add headers
                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                pdfTable.AddCell(new Phrase(column.HeaderText));
                            }

                            // Add rows
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if (row.IsNewRow) continue;
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                                }
                            }

                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
