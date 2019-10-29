namespace CapaPresentacion.Reporte
{
    partial class ReporteFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opciones1 = new CapaPresentacion.ControlesPropios.Opciones();
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.lblInicia = new MaterialSkin.Controls.MaterialLabel();
            this.lblTermina = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(192, 160);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(514, 330);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Grafico";
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(192, 64);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Shadow = null;
            this.materialListView1.ShadowShape = null;
            this.materialListView1.Size = new System.Drawing.Size(380, 90);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 400;
            // 
            // opciones1
            // 
            this.opciones1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.opciones1.Location = new System.Drawing.Point(0, 64);
            this.opciones1.Name = "opciones1";
            this.opciones1.Size = new System.Drawing.Size(182, 426);
            this.opciones1.TabIndex = 1;
            // 
            // materialPanel1
            // 
            this.materialPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel1.BackColor = System.Drawing.Color.Transparent;
            this.materialPanel1.ChangeBackColor = false;
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Location = new System.Drawing.Point(648, 64);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Primary = false;
            this.materialPanel1.RoundedCornerRadius = 2;
            this.materialPanel1.Shadow = null;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.materialPanel1.ShadowShape = graphicsPath1;
            this.materialPanel1.Size = new System.Drawing.Size(58, 49);
            this.materialPanel1.TabIndex = 8;
            // 
            // lblInicia
            // 
            this.lblInicia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicia.AutoSize = true;
            this.lblInicia.Depth = 0;
            this.lblInicia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInicia.FontSize = 11;
            this.lblInicia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInicia.Location = new System.Drawing.Point(578, 64);
            this.lblInicia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInicia.Name = "lblInicia";
            this.lblInicia.Primary = false;
            this.lblInicia.Shadow = null;
            this.lblInicia.ShadowShape = null;
            this.lblInicia.Size = new System.Drawing.Size(109, 19);
            this.lblInicia.TabIndex = 9;
            this.lblInicia.Text = "Inicia:00/00/00";
            // 
            // lblTermina
            // 
            this.lblTermina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTermina.AutoSize = true;
            this.lblTermina.Depth = 0;
            this.lblTermina.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTermina.FontSize = 11;
            this.lblTermina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTermina.Location = new System.Drawing.Point(578, 94);
            this.lblTermina.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTermina.Name = "lblTermina";
            this.lblTermina.Primary = false;
            this.lblTermina.Shadow = null;
            this.lblTermina.ShadowShape = null;
            this.lblTermina.Size = new System.Drawing.Size(124, 19);
            this.lblTermina.TabIndex = 11;
            this.lblTermina.Text = "Finaliza:00/00/00";
            // 
            // ReporteFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(718, 502);
            this.Controls.Add(this.lblTermina);
            this.Controls.Add(this.lblInicia);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.opciones1);
            this.Name = "ReporteFrm";
            this.Text = "ReporteFrm";
            this.Load += new System.EventHandler(this.ReporteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPropios.Opciones opciones1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialPanel materialPanel1;
        private MaterialSkin.Controls.MaterialLabel lblInicia;
        private MaterialSkin.Controls.MaterialLabel lblTermina;
    }
}