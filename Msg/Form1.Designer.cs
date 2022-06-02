namespace Msg
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
            this.pTop = new System.Windows.Forms.Panel();
            this.btnCer = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.pBot = new System.Windows.Forms.Panel();
            this.pSecond = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnWar = new System.Windows.Forms.Button();
            this.btnQues = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pTop.SuspendLayout();
            this.pSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pTop.Controls.Add(this.btnCer);
            this.pTop.Controls.Add(this.btnMax);
            this.pTop.Controls.Add(this.btnMin);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(900, 35);
            this.pTop.TabIndex = 0;
            // 
            // btnCer
            // 
            this.btnCer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCer.FlatAppearance.BorderSize = 0;
            this.btnCer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btnCer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btnCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCer.Image = global::Msg.Properties.Resources.close;
            this.btnCer.Location = new System.Drawing.Point(848, 0);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(50, 35);
            this.btnCer.TabIndex = 6;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::Msg.Properties.Resources.max;
            this.btnMax.Location = new System.Drawing.Point(798, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 35);
            this.btnMax.TabIndex = 8;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Msg.Properties.Resources.min;
            this.btnMin.Location = new System.Drawing.Point(748, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 35);
            this.btnMin.TabIndex = 7;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pLeft
            // 
            this.pLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 35);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(5, 753);
            this.pLeft.TabIndex = 1;
            // 
            // pRight
            // 
            this.pRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(895, 35);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(5, 753);
            this.pRight.TabIndex = 2;
            // 
            // pBot
            // 
            this.pBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBot.Location = new System.Drawing.Point(5, 783);
            this.pBot.Name = "pBot";
            this.pBot.Size = new System.Drawing.Size(890, 5);
            this.pBot.TabIndex = 3;
            // 
            // pSecond
            // 
            this.pSecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
            this.pSecond.Controls.Add(this.lblTitulo);
            this.pSecond.Location = new System.Drawing.Point(5, 35);
            this.pSecond.Name = "pSecond";
            this.pSecond.Size = new System.Drawing.Size(890, 50);
            this.pSecond.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.lblTitulo.Location = new System.Drawing.Point(11, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 33);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "JnG - Proyectos - MessageBox ";
            // 
            // btnWar
            // 
            this.btnWar.Location = new System.Drawing.Point(22, 118);
            this.btnWar.Name = "btnWar";
            this.btnWar.Size = new System.Drawing.Size(84, 29);
            this.btnWar.TabIndex = 5;
            this.btnWar.Text = "Precaucion";
            this.btnWar.UseVisualStyleBackColor = true;
            this.btnWar.Click += new System.EventHandler(this.btnWar_Click);
            // 
            // btnQues
            // 
            this.btnQues.Location = new System.Drawing.Point(22, 153);
            this.btnQues.Name = "btnQues";
            this.btnQues.Size = new System.Drawing.Size(84, 29);
            this.btnQues.TabIndex = 5;
            this.btnQues.Text = "Pregunta";
            this.btnQues.UseVisualStyleBackColor = true;
            this.btnQues.Click += new System.EventHandler(this.btnQues_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(22, 188);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(84, 29);
            this.btnError.TabIndex = 5;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(900, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnQues);
            this.Controls.Add(this.btnWar);
            this.Controls.Add(this.pSecond);
            this.Controls.Add(this.pBot);
            this.Controls.Add(this.pRight);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pTop.ResumeLayout(false);
            this.pSecond.ResumeLayout(false);
            this.pSecond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.Panel pBot;
        private System.Windows.Forms.Panel pSecond;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnWar;
        private System.Windows.Forms.Button btnQues;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Label label1;
    }
}

