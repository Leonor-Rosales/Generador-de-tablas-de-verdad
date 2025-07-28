namespace Generador_de_tablas_de_verdad
{
    partial class Generador
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
            flpVariables = new FlowLayoutPanel();
            txtExpresion = new TextBox();
            gbVariables = new GroupBox();
            gpbOperadores = new GroupBox();
            flpOperadores = new FlowLayoutPanel();
            button1 = new Button();
            btnEvaluar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            ibHome = new FontAwesome.Sharp.IconButton();
            ibSalir = new FontAwesome.Sharp.IconButton();
            dgvTabla = new DataGridView();
            gbVariables.SuspendLayout();
            gpbOperadores.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // flpVariables
            // 
            flpVariables.AutoScroll = true;
            flpVariables.Location = new Point(60, 39);
            flpVariables.Margin = new Padding(35, 30, 35, 30);
            flpVariables.Name = "flpVariables";
            flpVariables.Size = new Size(595, 223);
            flpVariables.TabIndex = 0;
            // 
            // txtExpresion
            // 
            txtExpresion.BackColor = Color.FromArgb(252, 247, 211);
            txtExpresion.Location = new Point(91, 427);
            txtExpresion.Margin = new Padding(4);
            txtExpresion.Multiline = true;
            txtExpresion.Name = "txtExpresion";
            txtExpresion.Size = new Size(982, 49);
            txtExpresion.TabIndex = 2;
            // 
            // gbVariables
            // 
            gbVariables.BackColor = Color.FromArgb(222, 232, 190);
            gbVariables.Controls.Add(flpVariables);
            gbVariables.Location = new Point(45, 92);
            gbVariables.Name = "gbVariables";
            gbVariables.Padding = new Padding(25);
            gbVariables.Size = new Size(715, 295);
            gbVariables.TabIndex = 3;
            gbVariables.TabStop = false;
            gbVariables.Text = "Variables";
            gbVariables.Enter += gbVariables_Enter;
            // 
            // gpbOperadores
            // 
            gpbOperadores.BackColor = Color.FromArgb(222, 232, 190);
            gpbOperadores.Controls.Add(flpOperadores);
            gpbOperadores.Location = new Point(785, 92);
            gpbOperadores.Name = "gpbOperadores";
            gpbOperadores.Padding = new Padding(25);
            gpbOperadores.Size = new Size(715, 295);
            gpbOperadores.TabIndex = 4;
            gpbOperadores.TabStop = false;
            gpbOperadores.Text = "Operadores";
            // 
            // flpOperadores
            // 
            flpOperadores.AutoScroll = true;
            flpOperadores.Location = new Point(60, 39);
            flpOperadores.Margin = new Padding(35, 30, 35, 30);
            flpOperadores.Name = "flpOperadores";
            flpOperadores.Size = new Size(595, 223);
            flpOperadores.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(692, 492);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEvaluar
            // 
            btnEvaluar.BackColor = Color.FromArgb(205, 140, 82);
            btnEvaluar.FlatAppearance.BorderSize = 0;
            btnEvaluar.FlatStyle = FlatStyle.Flat;
            btnEvaluar.ForeColor = Color.White;
            btnEvaluar.Location = new Point(1102, 431);
            btnEvaluar.Margin = new Padding(25);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(149, 47);
            btnEvaluar.TabIndex = 6;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = false;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(205, 140, 82);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(1301, 431);
            btnLimpiar.Margin = new Padding(25);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 47);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(205, 140, 82);
            panel1.Controls.Add(ibHome);
            panel1.Controls.Add(ibSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1552, 57);
            panel1.TabIndex = 8;
            // 
            // ibHome
            // 
            ibHome.BackColor = Color.FromArgb(205, 140, 82);
            ibHome.Dock = DockStyle.Right;
            ibHome.FlatAppearance.BorderSize = 0;
            ibHome.FlatStyle = FlatStyle.Flat;
            ibHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            ibHome.IconColor = Color.Black;
            ibHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibHome.Location = new Point(1384, 0);
            ibHome.Name = "ibHome";
            ibHome.Size = new Size(84, 57);
            ibHome.TabIndex = 1;
            ibHome.UseVisualStyleBackColor = false;
            ibHome.Click += ibHome_Click;
            // 
            // ibSalir
            // 
            ibSalir.Dock = DockStyle.Right;
            ibSalir.FlatAppearance.BorderSize = 0;
            ibSalir.FlatStyle = FlatStyle.Flat;
            ibSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            ibSalir.IconColor = Color.Black;
            ibSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibSalir.IconSize = 40;
            ibSalir.Location = new Point(1468, 0);
            ibSalir.Name = "ibSalir";
            ibSalir.Size = new Size(84, 57);
            ibSalir.TabIndex = 0;
            ibSalir.UseVisualStyleBackColor = false;
            ibSalir.Click += ibSalir_Click;
            // 
            // dgvTabla
            // 
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(59, 509);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.RowHeadersWidth = 62;
            dgvTabla.Size = new Size(1450, 516);
            dgvTabla.TabIndex = 9;
            dgvTabla.CellContentClick += dgvTabla_CellContentClick;
            // 
            // Generador
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 209, 163);
            ClientSize = new Size(1552, 1055);
            Controls.Add(dgvTabla);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEvaluar);
            Controls.Add(button1);
            Controls.Add(gpbOperadores);
            Controls.Add(gbVariables);
            Controls.Add(txtExpresion);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Generador";
            Text = "Generador";
            Load += Generador_Load;
            gbVariables.ResumeLayout(false);
            gpbOperadores.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpVariables;
        private TextBox txtExpresion;
        private GroupBox gbVariables;
        private GroupBox gpbOperadores;
        private FlowLayoutPanel flpOperadores;
        private Button button1;
        private Button btnEvaluar;
        private Button btnLimpiar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ibHome;
        private FontAwesome.Sharp.IconButton ibSalir;
        private DataGridView dgvTabla;
    }
}