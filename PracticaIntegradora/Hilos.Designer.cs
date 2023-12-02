namespace PracticaIntegradora
{
    partial class Hilos
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
            this.btn_tareas = new System.Windows.Forms.Button();
            this.lv_tareas = new System.Windows.Forms.ListView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tareas
            // 
            this.btn_tareas.Location = new System.Drawing.Point(279, 67);
            this.btn_tareas.Name = "btn_tareas";
            this.btn_tareas.Size = new System.Drawing.Size(195, 36);
            this.btn_tareas.TabIndex = 0;
            this.btn_tareas.Text = "Ver Tareas";
            this.btn_tareas.UseVisualStyleBackColor = true;
            this.btn_tareas.Click += new System.EventHandler(this.btn_tareas_Click);
            // 
            // lv_tareas
            // 
            this.lv_tareas.HideSelection = false;
            this.lv_tareas.Location = new System.Drawing.Point(136, 165);
            this.lv_tareas.Name = "lv_tareas";
            this.lv_tareas.Size = new System.Drawing.Size(468, 255);
            this.lv_tareas.TabIndex = 1;
            this.lv_tareas.UseCompatibleStateImageBehavior = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(638, 385);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(138, 35);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lv_tareas);
            this.Controls.Add(this.btn_tareas);
            this.Name = "Hilos";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Hilos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tareas;
        private System.Windows.Forms.ListView lv_tareas;
        private System.Windows.Forms.Button btn_regresar;
    }
}