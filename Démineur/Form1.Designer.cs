namespace Démineur
{
    partial class FJeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.partieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermédiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meilleursScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_flags = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.ts_new_game = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_ready = new System.Windows.Forms.ToolStripStatusLabel();
            this.game_panel = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partieToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(558, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // partieToolStripMenuItem
            // 
            this.partieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.niveauToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.meilleursScoresToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.partieToolStripMenuItem.Name = "partieToolStripMenuItem";
            this.partieToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.partieToolStripMenuItem.Text = "&Partie";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nouveauToolStripMenuItem.Text = "&Nouveau";
            // 
            // niveauToolStripMenuItem
            // 
            this.niveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facileToolStripMenuItem,
            this.intermédiaireToolStripMenuItem,
            this.difficileToolStripMenuItem});
            this.niveauToolStripMenuItem.Name = "niveauToolStripMenuItem";
            this.niveauToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.niveauToolStripMenuItem.Text = "N&iveau";
            // 
            // facileToolStripMenuItem
            // 
            this.facileToolStripMenuItem.Name = "facileToolStripMenuItem";
            this.facileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.facileToolStripMenuItem.Text = "&Facile";
            // 
            // intermédiaireToolStripMenuItem
            // 
            this.intermédiaireToolStripMenuItem.Name = "intermédiaireToolStripMenuItem";
            this.intermédiaireToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.intermédiaireToolStripMenuItem.Text = "In&termédiaire";
            // 
            // difficileToolStripMenuItem
            // 
            this.difficileToolStripMenuItem.Name = "difficileToolStripMenuItem";
            this.difficileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.difficileToolStripMenuItem.Text = "&Difficile";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // meilleursScoresToolStripMenuItem
            // 
            this.meilleursScoresToolStripMenuItem.Name = "meilleursScoresToolStripMenuItem";
            this.meilleursScoresToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.meilleursScoresToolStripMenuItem.Text = "&Meilleurs scores";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposToolStripMenuItem.Text = "A P&ropos";
            // 
            // tb_flags
            // 
            this.tb_flags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_flags.Enabled = false;
            this.tb_flags.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_flags.Location = new System.Drawing.Point(12, 28);
            this.tb_flags.Name = "tb_flags";
            this.tb_flags.ReadOnly = true;
            this.tb_flags.Size = new System.Drawing.Size(42, 43);
            this.tb_flags.TabIndex = 1;
            this.tb_flags.Text = "0";
            this.tb_flags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_time
            // 
            this.tb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_time.Enabled = false;
            this.tb_time.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_time.Location = new System.Drawing.Point(490, 28);
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = true;
            this.tb_time.Size = new System.Drawing.Size(56, 43);
            this.tb_time.TabIndex = 2;
            this.tb_time.Text = "0";
            this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_new_game,
            this.ts_ready});
            this.status.Location = new System.Drawing.Point(0, 507);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(558, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 3;
            // 
            // ts_new_game
            // 
            this.ts_new_game.Name = "ts_new_game";
            this.ts_new_game.Size = new System.Drawing.Size(267, 17);
            this.ts_new_game.Text = "Lancez une nouvelle partie pour commencer";
            // 
            // ts_ready
            // 
            this.ts_ready.Name = "ts_ready";
            this.ts_ready.Size = new System.Drawing.Size(95, 17);
            this.ts_ready.Text = "Partie en cours";
            this.ts_ready.Visible = false;
            // 
            // game_panel
            // 
            this.game_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_panel.Location = new System.Drawing.Point(12, 77);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(534, 427);
            this.game_panel.TabIndex = 4;
            // 
            // FJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 529);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_flags);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FJeu";
            this.Text = "Démineur";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem partieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermédiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meilleursScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_flags;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel ts_new_game;
        private System.Windows.Forms.ToolStripStatusLabel ts_ready;
        private System.Windows.Forms.Panel game_panel;
    }
}

