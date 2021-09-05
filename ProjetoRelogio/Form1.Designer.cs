
namespace ProjetoRelogio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Castellar", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.lblHora.Location = new System.Drawing.Point(47, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(249, 116);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "13:51";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSegundo.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.lblSegundo.Location = new System.Drawing.Point(302, 127);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(70, 48);
            this.lblSegundo.TabIndex = 1;
            this.lblSegundo.Text = "10";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Noto Sans Cond", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.lblDia.Location = new System.Drawing.Point(44, 221);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(149, 51);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Monday";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(70)))));
            this.lblData.Location = new System.Drawing.Point(367, 236);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 22);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(512, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

