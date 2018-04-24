namespace Login
{
    partial class Reportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reporte_1 = new System.Windows.Forms.TabPage();
            this.Grafico_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Reporte_2 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.Grafico_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.Reporte_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico_1)).BeginInit();
            this.Reporte_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico_2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reporte_1);
            this.tabControl1.Controls.Add(this.Reporte_2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 448);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Reporte_1
            // 
            this.Reporte_1.Controls.Add(this.Grafico_1);
            this.Reporte_1.Location = new System.Drawing.Point(4, 29);
            this.Reporte_1.Name = "Reporte_1";
            this.Reporte_1.Padding = new System.Windows.Forms.Padding(3);
            this.Reporte_1.Size = new System.Drawing.Size(935, 415);
            this.Reporte_1.TabIndex = 0;
            this.Reporte_1.Text = "Reporte 1";
            this.Reporte_1.UseVisualStyleBackColor = true;
            // 
            // Grafico_1
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafico_1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico_1.Legends.Add(legend1);
            this.Grafico_1.Location = new System.Drawing.Point(6, 6);
            this.Grafico_1.Name = "Grafico_1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafico_1.Series.Add(series1);
            this.Grafico_1.Size = new System.Drawing.Size(923, 406);
            this.Grafico_1.TabIndex = 0;
            this.Grafico_1.Text = "chart1";
            // 
            // Reporte_2
            // 
            this.Reporte_2.Controls.Add(this.btnBuscar);
            this.Reporte_2.Controls.Add(this.label3);
            this.Reporte_2.Controls.Add(this.Fecha2);
            this.Reporte_2.Controls.Add(this.label2);
            this.Reporte_2.Controls.Add(this.label1);
            this.Reporte_2.Controls.Add(this.Fecha1);
            this.Reporte_2.Controls.Add(this.Grafico_2);
            this.Reporte_2.Location = new System.Drawing.Point(4, 29);
            this.Reporte_2.Name = "Reporte_2";
            this.Reporte_2.Padding = new System.Windows.Forms.Padding(3);
            this.Reporte_2.Size = new System.Drawing.Size(935, 415);
            this.Reporte_2.TabIndex = 1;
            this.Reporte_2.Text = "Reporte 2";
            this.Reporte_2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(75)))), ((int)(((byte)(61)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(708, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccionar Fechas";
            // 
            // Fecha2
            // 
            this.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha2.Location = new System.Drawing.Point(514, 8);
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.Size = new System.Drawing.Size(123, 26);
            this.Fecha2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha 1";
            // 
            // Fecha1
            // 
            this.Fecha1.CustomFormat = "";
            this.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha1.Location = new System.Drawing.Point(296, 8);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(123, 26);
            this.Fecha1.TabIndex = 1;
            // 
            // Grafico_2
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafico_2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Grafico_2.Legends.Add(legend2);
            this.Grafico_2.Location = new System.Drawing.Point(6, 39);
            this.Grafico_2.Name = "Grafico_2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Grafico_2.Series.Add(series2);
            this.Grafico_2.Size = new System.Drawing.Size(923, 370);
            this.Grafico_2.TabIndex = 0;
            this.Grafico_2.Text = "chart2";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(967, 472);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.tabControl1.ResumeLayout(false);
            this.Reporte_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafico_1)).EndInit();
            this.Reporte_2.ResumeLayout(false);
            this.Reporte_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Reporte_1;
        private System.Windows.Forms.TabPage Reporte_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico_2;
        private System.Windows.Forms.DateTimePicker Fecha1;
        private System.Windows.Forms.DateTimePicker Fecha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
    }
}