﻿namespace CapaPresentacion.Productos
{
    partial class ProductosFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.contenedorTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorTarjetas
            // 
            this.contenedorTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedorTarjetas.Location = new System.Drawing.Point(188, 64);
            this.contenedorTarjetas.Name = "contenedorTarjetas";
            this.contenedorTarjetas.Size = new System.Drawing.Size(676, 424);
            this.contenedorTarjetas.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto", 9F);
            this.btnAgregar.FontSize = 9;
            this.btnAgregar.Icon = global::CapaPresentacion.Properties.Resources.plus;
            this.btnAgregar.Location = new System.Drawing.Point(812, 440);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.RoundedCornerRadius = 28;
            this.btnAgregar.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnAgregar.ShadowShape = graphicsPath1;
            this.btnAgregar.Size = new System.Drawing.Size(52, 51);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(182, 427);
            this.opciones1.TabIndex = 0;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditar,
            this.toolStripMenuItemEliminar});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Shadow = null;
            this.materialContextMenuStrip1.ShadowShape = null;
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            this.materialContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.materialContextMenuStrip1_Opening);
            // 
            // toolStripMenuItemEditar
            // 
            this.toolStripMenuItemEditar.Name = "toolStripMenuItemEditar";
            this.toolStripMenuItemEditar.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEditar.Text = "Editar";
            this.toolStripMenuItemEditar.Click += new System.EventHandler(this.toolStripMenuItemEditar_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            this.toolStripMenuItemEliminar.Click += new System.EventHandler(this.toolStripMenuItemEliminar_Click);
            // 
            // ProductosFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(876, 503);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.contenedorTarjetas);
            this.Controls.Add(this.opciones1);
            this.Name = "ProductosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductosFrmCate";
            this.Load += new System.EventHandler(this.ProductosFrm_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.FlowLayoutPanel contenedorTarjetas;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
    }
}