namespace PracticaIntegradora
{
    partial class Menu
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
            this.btn_clima = new System.Windows.Forms.Button();
            this.btn_tareas = new System.Windows.Forms.Button();
            this.btn_servidor = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clima
            // 
            this.btn_clima.Location = new System.Drawing.Point(71, 239);
            this.btn_clima.Name = "btn_clima";
            this.btn_clima.Size = new System.Drawing.Size(149, 42);
            this.btn_clima.TabIndex = 0;
            this.btn_clima.Text = "Pagar a Empleados";
            this.btn_clima.UseVisualStyleBackColor = true;
            this.btn_clima.Click += new System.EventHandler(this.btn_clima_Click);
            // 
            // btn_tareas
            // 
            this.btn_tareas.Location = new System.Drawing.Point(586, 239);
            this.btn_tareas.Name = "btn_tareas";
            this.btn_tareas.Size = new System.Drawing.Size(149, 42);
            this.btn_tareas.TabIndex = 1;
            this.btn_tareas.Text = "Ver Tareas";
            this.btn_tareas.UseVisualStyleBackColor = true;
            this.btn_tareas.Click += new System.EventHandler(this.btn_tareas_Click);
            // 
            // btn_servidor
            // 
            this.btn_servidor.Location = new System.Drawing.Point(328, 239);
            this.btn_servidor.Name = "btn_servidor";
            this.btn_servidor.Size = new System.Drawing.Size(149, 42);
            this.btn_servidor.TabIndex = 2;
            this.btn_servidor.Text = "Consultar Servidor";
            this.btn_servidor.UseVisualStyleBackColor = true;
            this.btn_servidor.Click += new System.EventHandler(this.btn_servidor_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.Location = new System.Drawing.Point(328, 111);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(149, 42);
            this.btn_empleados.TabIndex = 3;
            this.btn_empleados.Text = "ABC Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 458);
            this.Controls.Add(this.btn_empleados);
            this.Controls.Add(this.btn_servidor);
            this.Controls.Add(this.btn_tareas);
            this.Controls.Add(this.btn_clima);
            this.Name = "Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clima;
        private System.Windows.Forms.Button btn_tareas;
        private System.Windows.Forms.Button btn_servidor;
        private System.Windows.Forms.Button btn_empleados;
    }
}