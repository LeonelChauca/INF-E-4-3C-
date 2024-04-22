namespace E_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            ap_paterno = new DataGridViewTextBoxColumn();
            ap_materno = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 30);
            button1.Name = "button1";
            button1.Size = new Size(176, 30);
            button1.TabIndex = 0;
            button1.Text = "Recuperar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, ap_paterno, ap_materno, correo, tipo, departamento });
            dataGridView1.Location = new Point(80, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(458, 201);
            dataGridView1.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // ap_paterno
            // 
            ap_paterno.HeaderText = "ap_paterno";
            ap_paterno.Name = "ap_paterno";
            // 
            // ap_materno
            // 
            ap_materno.HeaderText = "ap_materno";
            ap_materno.Name = "ap_materno";
            // 
            // correo
            // 
            correo.HeaderText = "correo";
            correo.Name = "correo";
            // 
            // tipo
            // 
            tipo.HeaderText = "tipo";
            tipo.Name = "tipo";
            // 
            // departamento
            // 
            departamento.HeaderText = "departamento";
            departamento.Name = "departamento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 341);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ap_paterno;
        private DataGridViewTextBoxColumn ap_materno;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn departamento;
    }
}
