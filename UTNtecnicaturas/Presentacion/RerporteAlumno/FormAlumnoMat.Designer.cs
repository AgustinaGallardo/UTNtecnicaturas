namespace UTNtecnicaturas.Presentacion.RerporteAlumno
{
    partial class FormAlumnoMat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnoMat));
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.dataAlumno = new UTNtecnicaturas.Presentacion.RerporteAlumno.DataAlumno();
            this.dataAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_Alumno_materias_informacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Alumno_materias_informacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(307, 128);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 2;
            // 
            // dataAlumno
            // 
            this.dataAlumno.DataSetName = "DataAlumno";
            this.dataAlumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAlumnoBindingSource
            // 
            this.dataAlumnoBindingSource.DataSource = this.dataAlumno;
            this.dataAlumnoBindingSource.Position = 0;
            // 
            // Sp_Alumno_materias_informacionBindingSource
            // 
            this.Sp_Alumno_materias_informacionBindingSource.DataMember = "Sp_Alumno_materias_informacion";
            this.Sp_Alumno_materias_informacionBindingSource.DataSource = this.dataAlumno;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UTNtecnicaturas.Presentacion.RerporteAlumno.ReportAlumno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 176);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 262);
            this.reportViewer1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(434, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.Color.RoyalBlue;
            this.Consultar.FlatAppearance.BorderSize = 0;
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Consultar.Location = new System.Drawing.Point(434, 104);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(103, 30);
            this.Consultar.TabIndex = 19;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Legajo:";
            // 
            // FormAlumnoMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UTNtecnicaturas.Properties.Resources.WhatsApp_Image_2022_10_26_at_9_01_54_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlumnoMat";
            this.Text = "Reporte N° 9";
            this.Load += new System.EventHandler(this.FormAlumnoMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Alumno_materias_informacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.BindingSource dataAlumnoBindingSource;
        private DataAlumno dataAlumno;
        private System.Windows.Forms.BindingSource Sp_Alumno_materias_informacionBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Label label2;
    }
}