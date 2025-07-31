namespace Generador_de_tablas_de_verdad
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            numAsignacion = new GroupBox();
            btnIngresar = new Button();
            nupCantidadVariables = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            ibSalir = new FontAwesome.Sharp.IconButton();
            numAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadVariables).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numAsignacion
            // 
            numAsignacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numAsignacion.BackColor = Color.FromArgb(222, 232, 190);
            numAsignacion.Controls.Add(btnIngresar);
            numAsignacion.Controls.Add(nupCantidadVariables);
            numAsignacion.Controls.Add(label1);
            numAsignacion.Location = new Point(79, 93);
            numAsignacion.Margin = new Padding(70, 60, 70, 60);
            numAsignacion.Name = "numAsignacion";
            numAsignacion.Padding = new Padding(4);
            numAsignacion.Size = new Size(699, 323);
            numAsignacion.TabIndex = 0;
            numAsignacion.TabStop = false;
            numAsignacion.Text = "Asignación de Variables";
            numAsignacion.Enter += groupBox1_Enter;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(205, 140, 82);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(426, 211);
            btnIngresar.Margin = new Padding(4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(228, 59);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // nupCantidadVariables
            // 
            nupCantidadVariables.BackColor = Color.White;
            nupCantidadVariables.BorderStyle = BorderStyle.FixedSingle;
            nupCantidadVariables.Location = new Point(410, 131);
            nupCantidadVariables.Margin = new Padding(4);
            nupCantidadVariables.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupCantidadVariables.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupCantidadVariables.Name = "nupCantidadVariables";
            nupCantidadVariables.Size = new Size(148, 32);
            nupCantidadVariables.TabIndex = 1;
            nupCantidadVariables.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(94, 57, 41);
            label1.Location = new Point(111, 133);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 23);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de Variables:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 140, 82);
            panel1.Controls.Add(ibSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 46);
            panel1.TabIndex = 1;
            // 
            // ibSalir
            // 
            ibSalir.BackColor = Color.FromArgb(205, 140, 82);
            ibSalir.Dock = DockStyle.Right;
            ibSalir.FlatAppearance.BorderSize = 0;
            ibSalir.FlatStyle = FlatStyle.Flat;
            ibSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            ibSalir.IconColor = Color.White;
            ibSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibSalir.IconSize = 40;
            ibSalir.Location = new Point(767, 0);
            ibSalir.Name = "ibSalir";
            ibSalir.Size = new Size(97, 46);
            ibSalir.TabIndex = 0;
            ibSalir.UseVisualStyleBackColor = false;
            ibSalir.Click += ibSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 209, 163);
            ClientSize = new Size(864, 464);
            Controls.Add(panel1);
            Controls.Add(numAsignacion);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            numAsignacion.ResumeLayout(false);
            numAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadVariables).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox numAsignacion;
        private NumericUpDown nupCantidadVariables;
        private Label label1;
        private Button btnIngresar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ibSalir;
    }
}
