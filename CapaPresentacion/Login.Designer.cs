namespace CapaPresentacion
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNingresar = new FontAwesome.Sharp.IconButton();
            this.BTNcancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 234);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Ventas";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 114;
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 53);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(114, 117);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(222, 53);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(260, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(222, 112);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(260, 20);
            this.txtClave.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // BTNingresar
            // 
            this.BTNingresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNingresar.ForeColor = System.Drawing.Color.White;
            this.BTNingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BTNingresar.IconColor = System.Drawing.Color.White;
            this.BTNingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNingresar.IconSize = 21;
            this.BTNingresar.Location = new System.Drawing.Point(222, 170);
            this.BTNingresar.Name = "BTNingresar";
            this.BTNingresar.Size = new System.Drawing.Size(96, 40);
            this.BTNingresar.TabIndex = 7;
            this.BTNingresar.Text = "Ingresar";
            this.BTNingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNingresar.UseVisualStyleBackColor = false;
            this.BTNingresar.Click += new System.EventHandler(this.BTNingresar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BTNcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcancelar.ForeColor = System.Drawing.Color.White;
            this.BTNcancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BTNcancelar.IconColor = System.Drawing.Color.White;
            this.BTNcancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNcancelar.IconSize = 21;
            this.BTNcancelar.Location = new System.Drawing.Point(407, 170);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(92, 40);
            this.BTNcancelar.TabIndex = 8;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNcancelar.UseVisualStyleBackColor = false;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 234);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNingresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BTNingresar;
        private FontAwesome.Sharp.IconButton BTNcancelar;
    }
}