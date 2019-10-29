using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Caja
{
    public class ImprimeTicket
    {
        private IEnumerable<ProductoOrdenUC> lista;

        public ImprimeTicket(IEnumerable<ProductoOrdenUC> lista)
        {
            this.lista = lista;
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDocument document = (PrintDocument)sender;

            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            Font font = new Font("Arial", 12);

            int x = 0, y = 0, width = 210, height = 30;
            decimal total = 0;
            foreach (ProductoOrdenUC producto in lista)
            {
                g.DrawString(producto.ToString(), font, brush, x + 10, y);
                y += 30;
                total += producto.Precio;
            }

            g.DrawString("Total: " + total, font, brush, x + 10, y);
        }

        public bool Imprimir()
        {
            try
            {
                PrintDocument document = new PrintDocument();
                document.DefaultPageSettings.Landscape = true;
                document.PrintPage += new PrintPageEventHandler(document_PrintPage);

                document.Print();
                return true;
            }
            catch (Exception e)
            {
                Log.Write("Error no se puedo imprimir");
                MessageBox.Show("Error no se puedo imprimir");
                return false;
            }
            /* PrintPreviewDialog ppDialog = new PrintPreviewDialog();
            ppDialog.Document = document;
            ppDialog.Show();
            */
        }
    }
}
