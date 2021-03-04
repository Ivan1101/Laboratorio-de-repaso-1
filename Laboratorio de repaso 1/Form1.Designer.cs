
namespace Laboratorio_de_repaso_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1_Empleado = new System.Windows.Forms.DataGridView();
            this.dataGridView2_Asistencia = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textsueldohora = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Asistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1_Empleado
            // 
            this.dataGridView1_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Empleado.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1_Empleado.Name = "dataGridView1_Empleado";
            this.dataGridView1_Empleado.Size = new System.Drawing.Size(336, 114);
            this.dataGridView1_Empleado.TabIndex = 2;
            // 
            // dataGridView2_Asistencia
            // 
            this.dataGridView2_Asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Asistencia.Location = new System.Drawing.Point(32, 154);
            this.dataGridView2_Asistencia.Name = "dataGridView2_Asistencia";
            this.dataGridView2_Asistencia.Size = new System.Drawing.Size(336, 119);
            this.dataGridView2_Asistencia.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sueldo de empleado";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(497, 29);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(122, 20);
            this.textCodigo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "No. Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sueldo por hora";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(497, 56);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(122, 20);
            this.textNombre.TabIndex = 10;
            // 
            // textsueldohora
            // 
            this.textsueldohora.Location = new System.Drawing.Point(497, 87);
            this.textsueldohora.Name = "textsueldohora";
            this.textsueldohora.Size = new System.Drawing.Size(122, 20);
            this.textsueldohora.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mostrar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textsueldohora);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2_Asistencia);
            this.Controls.Add(this.dataGridView1_Empleado);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Asistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1_Empleado;
        private System.Windows.Forms.DataGridView dataGridView2_Asistencia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textsueldohora;
        private System.Windows.Forms.Button button2;
    }
}

