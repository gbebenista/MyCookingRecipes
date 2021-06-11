﻿using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCookingRecipes
{
    public class PDFGenerator
    {
        public static void Generate(DataTable data, string title)
        {
            DateTime genTime = DateTime.Today;
            CultureInfo format = new CultureInfo("de-DE");
            string filename = String.Format("Lista zakupów_{0}.pdf",genTime.ToString(format));

            try
            {

                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string filepath = folderBrowserDialog.SelectedPath + "\\" + filename;
                        if (File.Exists(filepath))
                        {
                            MessageBox.Show("Taki plik już istnieje. Proszę usunąć (bądź zmienić nazwę) plik i spróbować ponownie");
                            return;
                        }
                        else
                        {
                            string exportFile = Path.Combine(folderBrowserDialog.SelectedPath, filename);
                            PdfWriter pdfWriter = new PdfWriter(exportFile);
                            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                            Document document = new Document(pdfDocument);

                            document.Add(new Paragraph(genTime.ToString()));
                            document.Add(new Paragraph(title).SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));

                            document.Add(toTable(data));
                            document.Close();

                            MessageBox.Show("Pomyślnie wygenerowano plik z listą zakupów");
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException acceserror)
            {
                Console.Write(acceserror);
                MessageBox.Show("Nie posiadasz uprawnień do zapisu pliku w wybranym katalogu. Proszę sprawdzić uprawnienia lub wybrać inny katalog");
            }
            catch (Exception e)
            {
                Console.Write(e);
                MessageBox.Show("Wystąpił problem z wygenerowaniem pliku z listą zakupów. Proszę spróbować ponownie");
            }



        }


        private static Table toTable(DataTable data)
        {
            try
            {
                Table result = new Table(data.Columns.Count);
                result.UseAllAvailableWidth();
                foreach (DataColumn column in data.Columns)
                {
                    result.AddHeaderCell(new Paragraph(column.ColumnName).SetFontSize(14).SetBold());
                }
                foreach (DataRow row in data.Rows)
                {
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        result.AddCell(new Paragraph(row[i].ToString()).SetFontSize(12));
                    }

                }
                return result;
            }

            catch (Exception e)
            {
                Console.Write(e.Message);
                return null;
            }
        }
    }
}
