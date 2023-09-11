namespace TravelAgency
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.btnProximo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupRegistro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupInicioSection = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtInicoPassword = new System.Windows.Forms.TextBox();
            this.txtInicioSection = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupRegistro.SuspendLayout();
            this.groupInicioSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Transparent;
            this.btnProximo.BackgroundImage = global::TravelAgency.Properties.Resources.proximo;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProximo.FlatAppearance.BorderColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProximo.Location = new System.Drawing.Point(717, 19);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(33, 26);
            this.btnProximo.TabIndex = 4;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agency...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupRegistro
            // 
            this.groupRegistro.BackColor = System.Drawing.Color.Transparent;
            this.groupRegistro.Controls.Add(this.button1);
            this.groupRegistro.Controls.Add(this.txtPassword);
            this.groupRegistro.Controls.Add(this.txtName);
            this.groupRegistro.Controls.Add(this.txtIdUsuario);
            this.groupRegistro.Controls.Add(this.label5);
            this.groupRegistro.Controls.Add(this.label4);
            this.groupRegistro.Controls.Add(this.label3);
            this.groupRegistro.Controls.Add(this.label2);
            this.groupRegistro.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRegistro.Location = new System.Drawing.Point(431, 72);
            this.groupRegistro.Name = "groupRegistro";
            this.groupRegistro.Size = new System.Drawing.Size(289, 214);
            this.groupRegistro.TabIndex = 2;
            this.groupRegistro.TabStop = false;
            this.groupRegistro.Text = "Registration";
            this.groupRegistro.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(101, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(172, 19);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(101, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 19);
            this.txtName.TabIndex = 6;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdUsuario.Location = new System.Drawing.Point(100, 36);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(172, 19);
            this.txtIdUsuario.TabIndex = 5;
            this.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correo";
            // 
            // groupInicioSection
            // 
            this.groupInicioSection.BackColor = System.Drawing.Color.Transparent;
            this.groupInicioSection.Controls.Add(this.btnIngresar);
            this.groupInicioSection.Controls.Add(this.txtInicoPassword);
            this.groupInicioSection.Controls.Add(this.txtInicioSection);
            this.groupInicioSection.Controls.Add(this.label8);
            this.groupInicioSection.Controls.Add(this.label7);
            this.groupInicioSection.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInicioSection.Location = new System.Drawing.Point(97, 72);
            this.groupInicioSection.Name = "groupInicioSection";
            this.groupInicioSection.Size = new System.Drawing.Size(264, 214);
            this.groupInicioSection.TabIndex = 4;
            this.groupInicioSection.TabStop = false;
            this.groupInicioSection.Text = "Home Section";
            this.groupInicioSection.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(94, 173);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Enter";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtInicoPassword
            // 
            this.txtInicoPassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtInicoPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInicoPassword.Location = new System.Drawing.Point(54, 121);
            this.txtInicoPassword.Name = "txtInicoPassword";
            this.txtInicoPassword.PasswordChar = '*';
            this.txtInicoPassword.Size = new System.Drawing.Size(160, 19);
            this.txtInicoPassword.TabIndex = 3;
            this.txtInicoPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInicioSection
            // 
            this.txtInicioSection.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtInicioSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInicioSection.Location = new System.Drawing.Point(54, 63);
            this.txtInicioSection.Name = "txtInicioSection";
            this.txtInicioSection.Size = new System.Drawing.Size(160, 19);
            this.txtInicioSection.TabIndex = 2;
            this.txtInicioSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::TravelAgency.Properties.Resources.Agencia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupRegistro);
            this.Controls.Add(this.groupInicioSection);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupRegistro.ResumeLayout(false);
            this.groupRegistro.PerformLayout();
            this.groupInicioSection.ResumeLayout(false);
            this.groupInicioSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.GroupBox groupInicioSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInicoPassword;
        private System.Windows.Forms.TextBox txtInicioSection;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

