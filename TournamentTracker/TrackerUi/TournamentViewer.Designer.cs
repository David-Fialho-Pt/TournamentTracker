namespace TrackerUi
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            tournamentlabel = new Label();
            Tournamentnamelabel = new Label();
            roundlabel = new Label();
            rounddropdown = new ComboBox();
            unplayedonlycheckbox = new CheckBox();
            matchuplistbox = new ListBox();
            team1label = new Label();
            teamtwolabel = new Label();
            teamonescore = new Label();
            teamtwoscore = new Label();
            teamonescoretb = new TextBox();
            teamtwoscoretb = new TextBox();
            versuslabel = new Label();
            scorebutton = new Button();
            SuspendLayout();
            // 
            // tournamentlabel
            // 
            tournamentlabel.AutoSize = true;
            tournamentlabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentlabel.ForeColor = Color.DodgerBlue;
            tournamentlabel.Location = new Point(52, 46);
            tournamentlabel.Name = "tournamentlabel";
            tournamentlabel.Size = new Size(226, 50);
            tournamentlabel.TabIndex = 0;
            tournamentlabel.Text = "Tournament:";
            // 
            // Tournamentnamelabel
            // 
            Tournamentnamelabel.AutoSize = true;
            Tournamentnamelabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tournamentnamelabel.ForeColor = Color.DodgerBlue;
            Tournamentnamelabel.Location = new Point(270, 46);
            Tournamentnamelabel.Name = "Tournamentnamelabel";
            Tournamentnamelabel.Size = new Size(155, 50);
            Tournamentnamelabel.TabIndex = 1;
            Tournamentnamelabel.Text = "<none>";
            // 
            // roundlabel
            // 
            roundlabel.AutoSize = true;
            roundlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundlabel.ForeColor = Color.DodgerBlue;
            roundlabel.Location = new Point(52, 117);
            roundlabel.Name = "roundlabel";
            roundlabel.Size = new Size(94, 37);
            roundlabel.TabIndex = 2;
            roundlabel.Text = "Round";
            // 
            // rounddropdown
            // 
            rounddropdown.FormattingEnabled = true;
            rounddropdown.Location = new Point(171, 116);
            rounddropdown.Name = "rounddropdown";
            rounddropdown.Size = new Size(227, 38);
            rounddropdown.TabIndex = 3;
            rounddropdown.SelectedIndexChanged += rounddropdown_SelectedIndexChanged;
            // 
            // unplayedonlycheckbox
            // 
            unplayedonlycheckbox.AutoSize = true;
            unplayedonlycheckbox.FlatStyle = FlatStyle.Flat;
            unplayedonlycheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unplayedonlycheckbox.ForeColor = Color.DodgerBlue;
            unplayedonlycheckbox.Location = new Point(171, 160);
            unplayedonlycheckbox.Name = "unplayedonlycheckbox";
            unplayedonlycheckbox.Size = new Size(205, 41);
            unplayedonlycheckbox.TabIndex = 4;
            unplayedonlycheckbox.Text = "Unplayed only";
            unplayedonlycheckbox.UseVisualStyleBackColor = true;
            // 
            // matchuplistbox
            // 
            matchuplistbox.BorderStyle = BorderStyle.FixedSingle;
            matchuplistbox.FormattingEnabled = true;
            matchuplistbox.ItemHeight = 30;
            matchuplistbox.Location = new Point(66, 236);
            matchuplistbox.Name = "matchuplistbox";
            matchuplistbox.Size = new Size(359, 332);
            matchuplistbox.TabIndex = 5;
            matchuplistbox.SelectedIndexChanged += matchuplistbox_SelectedIndexChanged;
            // 
            // team1label
            // 
            team1label.AutoSize = true;
            team1label.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            team1label.ForeColor = Color.DodgerBlue;
            team1label.Location = new Point(565, 236);
            team1label.Name = "team1label";
            team1label.Size = new Size(167, 37);
            team1label.TabIndex = 6;
            team1label.Text = "<Team one>";
            // 
            // teamtwolabel
            // 
            teamtwolabel.AutoSize = true;
            teamtwolabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamtwolabel.ForeColor = Color.DodgerBlue;
            teamtwolabel.Location = new Point(565, 464);
            teamtwolabel.Name = "teamtwolabel";
            teamtwolabel.Size = new Size(171, 37);
            teamtwolabel.TabIndex = 7;
            teamtwolabel.Text = "<Team Two>";
            // 
            // teamonescore
            // 
            teamonescore.AutoSize = true;
            teamonescore.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamonescore.ForeColor = Color.DodgerBlue;
            teamonescore.Location = new Point(565, 288);
            teamonescore.Name = "teamonescore";
            teamonescore.Size = new Size(82, 37);
            teamonescore.TabIndex = 8;
            teamonescore.Text = "Score";
            // 
            // teamtwoscore
            // 
            teamtwoscore.AutoSize = true;
            teamtwoscore.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamtwoscore.ForeColor = Color.DodgerBlue;
            teamtwoscore.Location = new Point(569, 520);
            teamtwoscore.Name = "teamtwoscore";
            teamtwoscore.Size = new Size(82, 37);
            teamtwoscore.TabIndex = 9;
            teamtwoscore.Text = "Score";
            // 
            // teamonescoretb
            // 
            teamonescoretb.BorderStyle = BorderStyle.FixedSingle;
            teamonescoretb.Location = new Point(682, 291);
            teamonescoretb.Name = "teamonescoretb";
            teamonescoretb.Size = new Size(100, 35);
            teamonescoretb.TabIndex = 10;
            // 
            // teamtwoscoretb
            // 
            teamtwoscoretb.BorderStyle = BorderStyle.FixedSingle;
            teamtwoscoretb.Location = new Point(682, 523);
            teamtwoscoretb.Name = "teamtwoscoretb";
            teamtwoscoretb.Size = new Size(100, 35);
            teamtwoscoretb.TabIndex = 11;
            // 
            // versuslabel
            // 
            versuslabel.AutoSize = true;
            versuslabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versuslabel.ForeColor = Color.DodgerBlue;
            versuslabel.Location = new Point(650, 371);
            versuslabel.Name = "versuslabel";
            versuslabel.Size = new Size(70, 37);
            versuslabel.TabIndex = 12;
            versuslabel.Text = "-VS-";
            // 
            // scorebutton
            // 
            scorebutton.FlatAppearance.BorderColor = Color.Silver;
            scorebutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            scorebutton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            scorebutton.FlatStyle = FlatStyle.Flat;
            scorebutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scorebutton.ForeColor = Color.DodgerBlue;
            scorebutton.Location = new Point(780, 368);
            scorebutton.Name = "scorebutton";
            scorebutton.Size = new Size(123, 49);
            scorebutton.TabIndex = 13;
            scorebutton.Text = "Score";
            scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(938, 608);
            Controls.Add(scorebutton);
            Controls.Add(versuslabel);
            Controls.Add(teamtwoscoretb);
            Controls.Add(teamonescoretb);
            Controls.Add(teamtwoscore);
            Controls.Add(teamonescore);
            Controls.Add(teamtwolabel);
            Controls.Add(team1label);
            Controls.Add(matchuplistbox);
            Controls.Add(unplayedonlycheckbox);
            Controls.Add(rounddropdown);
            Controls.Add(roundlabel);
            Controls.Add(Tournamentnamelabel);
            Controls.Add(tournamentlabel);
            Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentlabel;
        private Label Tournamentnamelabel;
        private Label roundlabel;
        private ComboBox rounddropdown;
        private CheckBox unplayedonlycheckbox;
        private ListBox matchuplistbox;
        private Label team1label;
        private Label teamtwolabel;
        private Label teamonescore;
        private Label teamtwoscore;
        private TextBox teamonescoretb;
        private TextBox teamtwoscoretb;
        private Label versuslabel;
        private Button scorebutton;
    }
}
