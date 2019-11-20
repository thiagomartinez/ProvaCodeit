namespace ProvaCode
{
    partial class Form1
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
            this.LvEmbarque = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvAviao = new System.Windows.Forms.ListView();
            this.LvSmart = new System.Windows.Forms.ListView();
            this.LAviao = new System.Windows.Forms.Label();
            this.LEmbarque = new System.Windows.Forms.Label();
            this.LSmartFortwo = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnAdd1 = new System.Windows.Forms.Button();
            this.BtnDel1 = new System.Windows.Forms.Button();
            this.BtnDel2 = new System.Windows.Forms.Button();
            this.BtnAdd2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvEmbarque
            // 
            this.LvEmbarque.AutoArrange = false;
            this.LvEmbarque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LvEmbarque.Location = new System.Drawing.Point(23, 24);
            this.LvEmbarque.MultiSelect = false;
            this.LvEmbarque.Name = "LvEmbarque";
            this.LvEmbarque.Size = new System.Drawing.Size(169, 330);
            this.LvEmbarque.TabIndex = 18;
            this.LvEmbarque.UseCompatibleStateImageBehavior = false;
            this.LvEmbarque.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // LvAviao
            // 
            this.LvAviao.Location = new System.Drawing.Point(530, 24);
            this.LvAviao.MultiSelect = false;
            this.LvAviao.Name = "LvAviao";
            this.LvAviao.Size = new System.Drawing.Size(173, 330);
            this.LvAviao.TabIndex = 19;
            this.LvAviao.UseCompatibleStateImageBehavior = false;
            this.LvAviao.View = System.Windows.Forms.View.List;
            // 
            // LvSmart
            // 
            this.LvSmart.Location = new System.Drawing.Point(278, 113);
            this.LvSmart.MultiSelect = false;
            this.LvSmart.Name = "LvSmart";
            this.LvSmart.Size = new System.Drawing.Size(162, 100);
            this.LvSmart.TabIndex = 20;
            this.LvSmart.UseCompatibleStateImageBehavior = false;
            this.LvSmart.View = System.Windows.Forms.View.List;
            // 
            // LAviao
            // 
            this.LAviao.AutoSize = true;
            this.LAviao.Location = new System.Drawing.Point(527, 8);
            this.LAviao.Name = "LAviao";
            this.LAviao.Size = new System.Drawing.Size(34, 13);
            this.LAviao.TabIndex = 21;
            this.LAviao.Text = "Avião";
            // 
            // LEmbarque
            // 
            this.LEmbarque.AutoSize = true;
            this.LEmbarque.Location = new System.Drawing.Point(20, 9);
            this.LEmbarque.Name = "LEmbarque";
            this.LEmbarque.Size = new System.Drawing.Size(55, 13);
            this.LEmbarque.TabIndex = 22;
            this.LEmbarque.Text = "Embarque";
            // 
            // LSmartFortwo
            // 
            this.LSmartFortwo.AutoSize = true;
            this.LSmartFortwo.Location = new System.Drawing.Point(275, 97);
            this.LSmartFortwo.Name = "LSmartFortwo";
            this.LSmartFortwo.Size = new System.Drawing.Size(69, 13);
            this.LSmartFortwo.TabIndex = 23;
            this.LSmartFortwo.Text = "Smart Fortwo";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(278, 24);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(162, 32);
            this.BtnIniciar.TabIndex = 24;
            this.BtnIniciar.Text = "Iniciar/Reiniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnAdd1
            // 
            this.BtnAdd1.Location = new System.Drawing.Point(198, 125);
            this.BtnAdd1.Name = "BtnAdd1";
            this.BtnAdd1.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd1.TabIndex = 26;
            this.BtnAdd1.Text = ">";
            this.BtnAdd1.UseVisualStyleBackColor = true;
            this.BtnAdd1.Click += new System.EventHandler(this.BtnAdd1_Click);
            // 
            // BtnDel1
            // 
            this.BtnDel1.Location = new System.Drawing.Point(198, 170);
            this.BtnDel1.Name = "BtnDel1";
            this.BtnDel1.Size = new System.Drawing.Size(75, 23);
            this.BtnDel1.TabIndex = 27;
            this.BtnDel1.Text = "<";
            this.BtnDel1.UseVisualStyleBackColor = true;
            this.BtnDel1.Click += new System.EventHandler(this.BtnDel1_Click);
            // 
            // BtnDel2
            // 
            this.BtnDel2.Location = new System.Drawing.Point(446, 170);
            this.BtnDel2.Name = "BtnDel2";
            this.BtnDel2.Size = new System.Drawing.Size(75, 23);
            this.BtnDel2.TabIndex = 29;
            this.BtnDel2.Text = "<";
            this.BtnDel2.UseVisualStyleBackColor = true;
            this.BtnDel2.Click += new System.EventHandler(this.BtnDel2_Click);
            // 
            // BtnAdd2
            // 
            this.BtnAdd2.Location = new System.Drawing.Point(446, 125);
            this.BtnAdd2.Name = "BtnAdd2";
            this.BtnAdd2.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd2.TabIndex = 28;
            this.BtnAdd2.Text = ">";
            this.BtnAdd2.UseVisualStyleBackColor = true;
            this.BtnAdd2.Click += new System.EventHandler(this.BtnAdd2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 396);
            this.Controls.Add(this.BtnDel2);
            this.Controls.Add(this.BtnAdd2);
            this.Controls.Add(this.BtnDel1);
            this.Controls.Add(this.BtnAdd1);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LSmartFortwo);
            this.Controls.Add(this.LEmbarque);
            this.Controls.Add(this.LAviao);
            this.Controls.Add(this.LvSmart);
            this.Controls.Add(this.LvAviao);
            this.Controls.Add(this.LvEmbarque);
            this.Name = "Form1";
            this.Text = "Prova Codeit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LvEmbarque;
        private System.Windows.Forms.ListView LvAviao;
        private System.Windows.Forms.ListView LvSmart;
        private System.Windows.Forms.Label LAviao;
        private System.Windows.Forms.Label LEmbarque;
        private System.Windows.Forms.Label LSmartFortwo;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button BtnAdd1;
        private System.Windows.Forms.Button BtnDel1;
        private System.Windows.Forms.Button BtnDel2;
        private System.Windows.Forms.Button BtnAdd2;
    }
}

