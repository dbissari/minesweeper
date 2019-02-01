namespace Démineur
{
    partial class FWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWin));
            this.label = new System.Windows.Forms.Label();
            this.lbrecord = new System.Windows.Forms.Label();
            this.tbrecord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Vous avez gagné en ";
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.Location = new System.Drawing.Point(12, 70);
            this.lbrecord.MaximumSize = new System.Drawing.Size(180, 0);
            this.lbrecord.Name = "lbrecord";
            this.lbrecord.Size = new System.Drawing.Size(172, 34);
            this.lbrecord.TabIndex = 1;
            this.lbrecord.Text = "Vous venez de battre un record. Quel est votre nom?";
            // 
            // tbrecord
            // 
            this.tbrecord.Location = new System.Drawing.Point(190, 74);
            this.tbrecord.Name = "tbrecord";
            this.tbrecord.Size = new System.Drawing.Size(83, 30);
            this.tbrecord.TabIndex = 2;
            this.tbrecord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbrecord_KeyPress);
            // 
            // FWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 130);
            this.Controls.Add(this.tbrecord);
            this.Controls.Add(this.lbrecord);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FWin";
            this.ShowInTaskbar = false;
            this.Text = "Victoire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Label lbrecord;
        public System.Windows.Forms.TextBox tbrecord;

    }
}