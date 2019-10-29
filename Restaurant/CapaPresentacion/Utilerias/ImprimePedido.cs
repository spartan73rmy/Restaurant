using CapaLogica.Logger;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaPresentacion.VentanaPricipal;

namespace CapaPresentacion.Utilerias
{
    public class ImprimePedido
    {

        private int width = 30, height = 30;
        public ImprimePedido()
        {

        }

        public bool ImprimirNuevo(OrdenProductoSerializable ticket)
        {
            try
            {
                PrintDocument document = new PrintDocument();
                document.DefaultPageSettings.Landscape = true;
                document.PrintPage += new PrintPageEventHandler((sender, e) =>
                {

                    Graphics g = e.Graphics;
                    Brush brush = new SolidBrush(Color.Black);
                    Pen pen = new Pen(brush);
                    Font font = new Font("Arial", 12);
                    string linea = "";

                    int x = 0, y = 0, width = 30;
                    g.DrawString("AGREGADO", font, new SolidBrush(Color.Red), x + 10, y);
                    y += 30;
                    g.DrawString("Mesa: " + ticket.Mesa, font, brush, x + 10, y);
                    y += 30;

                    g.DrawString("-::-Producto:", font, brush, x + 10, y);
                    y += 30;

                    string[] producto = ("" + ticket).Split(' ');

                    for (int i = 0; i < producto.Length; i++)
                    {
                        string word = producto[i] + " ";
                        if (linea.Length + word.Length >= width)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                            linea = "";
                            i--;
                        }
                        else
                        {
                            linea += word;
                        }
                    }

                    if (linea.Length > 0)
                    {
                        g.DrawString(linea, font, brush, x + 10, y);
                        y += 30;
                    }


                    if (ticket.Variantes.Count > 0)
                    {
                        linea = "";
                        g.DrawString("-::-Variantes:", font, brush, x + 10, y);
                        y += 30;
                        foreach (var variante in ticket.Variantes)
                        {
                            string[] variant = variante.Nombre.Split(' ');

                            for (int i = 0; i < variant.Length; i++)
                            {
                                string word = variant[i] + " ";
                                if (linea.Length + word.Length >= width)
                                {
                                    g.DrawString(linea, font, brush, x + 10, y);
                                    y += 30;
                                    linea = "";
                                    i--;
                                }
                                else
                                {
                                    linea += word;
                                }
                            }

                            if (linea.Length > 0)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                            }
                        }
                    }

                    g.DrawString("-::-Cantidad: " + ticket.Cantidad, font, brush, x + 10, y);
                    y += 30;

                    if (ticket.Comentarios.Length > 0)
                    {
                        string[] coment = ticket.Comentarios.Split(' ');
                        linea = "-::-Comentarios: ";

                        for (int i = 0; i < coment.Length; i++)
                        {
                            string word = coment[i] + " ";
                            if (linea.Length + word.Length >= width)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                                linea = "";
                                i--;
                            }
                            else
                            {
                                linea += word;
                            }
                        }

                        if (linea.Length > 0)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                        }

                    }
                });

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


        public bool ImprimirEliminado(OrdenProductoSerializable ticket)
        {
            try
            {
                PrintDocument document = new PrintDocument();
                document.DefaultPageSettings.Landscape = true;
                document.PrintPage += new PrintPageEventHandler((sender, e) =>
                {
                    Graphics g = e.Graphics;
                    Brush brush = new SolidBrush(Color.Black);
                    Pen pen = new Pen(brush);
                    Font font = new Font("Arial", 12);
                    string linea = "";
                    int x = 0, y = 0;

                    g.DrawString("ELIMINADO", font, new SolidBrush(Color.Red), x + 10, y);
                    y += 30;

                    string[] producto = ("" + ticket).Split(' ');

                    for (int i = 0; i < producto.Length; i++)
                    {
                        string word = producto[i] + " ";
                        if (linea.Length + word.Length >= width)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                            linea = "";
                            i--;
                        }
                        else
                        {
                            linea += word;
                        }
                    }

                    if (linea.Length > 0)
                    {
                        g.DrawString(linea, font, brush, x + 10, y);
                        y += 30;
                    }

                    if (ticket.Variantes.Count > 0)
                    {
                        linea = "";
                        g.DrawString("-::-Variantes:", font, brush, x + 10, y);
                        y += 30;
                        foreach (var variante in ticket.Variantes)
                        {
                            string[] variant = variante.Nombre.Split(' ');

                            for (int i = 0; i < variant.Length; i++)
                            {
                                string word = variant[i] + " ";
                                if (linea.Length + word.Length >= width)
                                {
                                    g.DrawString(linea, font, brush, x + 10, y);
                                    y += 30;
                                    linea = "";
                                    i--;
                                }
                                else
                                {
                                    linea += word;
                                }
                            }

                            if (linea.Length > 0)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                            }
                        }
                    }

                    if (ticket.Comentarios.Length > 0)
                    {
                        string[] coment = ticket.Comentarios.Split(' ');
                        linea = "-::-Comentarios: ";

                        for (int i = 0; i < coment.Length; i++)
                        {
                            string word = coment[i] + " ";
                            if (linea.Length + word.Length >= width)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                                linea = "";
                                i--;
                            }
                            else
                            {
                                linea += word;
                            }
                        }

                        if (linea.Length > 0)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                        }

                    }

                    g.DrawString("Mesa: " + ticket.Mesa, font, brush, x + 10, y);


                });

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

        public bool ImprimirEditado(OrdenProductoSerializable viejo, OrdenProductoSerializable nuevo)
        {
            try
            {
                PrintDocument document = new PrintDocument();
                document.DefaultPageSettings.Landscape = true;
                document.PrintPage += new PrintPageEventHandler((sender, e) =>
                {
                    Graphics g = e.Graphics;
                    Brush brush = new SolidBrush(Color.Black);
                    Pen pen = new Pen(brush);
                    Font font = new Font("Arial", 12);
                    string linea = "";
                    int x = 0, y = 0;

                    g.DrawString("ELIMINADO", font, new SolidBrush(Color.Red), x + 10, y);
                    y += 30;

                    string[] producto = ("" + viejo).Split(' ');

                    for (int i = 0; i < producto.Length; i++)
                    {
                        string word = producto[i] + " ";
                        if (linea.Length + word.Length >= width)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                            linea = "";
                            i--;
                        }
                        else
                        {
                            linea += word;
                        }
                    }

                    if (linea.Length > 0)
                    {
                        g.DrawString(linea, font, brush, x + 10, y);
                        y += 30;
                    }

                    if (viejo.Variantes.Count > 0)
                    {
                        linea = "";
                        g.DrawString("-::-Variantes:", font, brush, x + 10, y);
                        y += 30;
                        foreach (var variante in viejo.Variantes)
                        {
                            string[] variant = variante.Nombre.Split(' ');

                            for (int i = 0; i < variant.Length; i++)
                            {
                                string word = variant[i] + " ";
                                if (linea.Length + word.Length >= width)
                                {
                                    g.DrawString(linea, font, brush, x + 10, y);
                                    y += 30;
                                    linea = "";
                                    i--;
                                }
                                else
                                {
                                    linea += word;
                                }
                            }

                            if (linea.Length > 0)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                            }
                        }
                    }

                    g.DrawString("Cantidad: " + viejo.Cantidad, font, brush, x + 10, y);
                    y += 30;

                    g.DrawString("AGREGADO", font, new SolidBrush(Color.Red), x + 10, y);
                    y += 30;

                    producto = ("" + nuevo).Split(' ');

                    for (int i = 0; i < producto.Length; i++)
                    {
                        string word = producto[i] + " ";
                        if (linea.Length + word.Length >= width)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                            linea = "";
                            i--;
                        }
                        else
                        {
                            linea += word;
                        }
                    }

                    if (linea.Length > 0)
                    {
                        g.DrawString(linea, font, brush, x + 10, y);
                        y += 30;
                    }

                    if (nuevo.Variantes.Count > 0)
                    {
                        linea = "";
                        g.DrawString("-::-Variantes:", font, brush, x + 10, y);
                        y += 30;
                        foreach (var variante in nuevo.Variantes)
                        {
                            string[] variant = variante.Nombre.Split(' ');

                            for (int i = 0; i < variant.Length; i++)
                            {
                                string word = variant[i] + " ";
                                if (linea.Length + word.Length >= width)
                                {
                                    g.DrawString(linea, font, brush, x + 10, y);
                                    y += 30;
                                    linea = "";
                                    i--;
                                }
                                else
                                {
                                    linea += word;
                                }
                            }

                            if (linea.Length > 0)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                            }
                        }
                    }

                    g.DrawString("-::-Cantidad: " + nuevo.Cantidad, font, brush, x + 10, y);
                    y += 30;

                    if (nuevo.Comentarios.Length > 0)
                    {
                        string[] coment = nuevo.Comentarios.Split(' ');
                        linea = "-::-Comentarios: ";

                        for (int i = 0; i < coment.Length; i++)
                        {
                            string word = coment[i] + " ";
                            if (linea.Length + word.Length >= width)
                            {
                                g.DrawString(linea, font, brush, x + 10, y);
                                y += 30;
                                linea = "";
                                i--;
                            }
                            else
                            {
                                linea += word;
                            }
                        }

                        if (linea.Length > 0)
                        {
                            g.DrawString(linea, font, brush, x + 10, y);
                            y += 30;
                        }

                    }
                    g.DrawString("Mesa: " + nuevo.Mesa, font, brush, x + 10, y);
                    y += 30;

                });

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
