namespace TrackerrUi
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            createtournamentbutton = new Button();
            RemoveSelectedPrize = new Button();
            prizeslbl = new Label();
            prizeslistbox = new ListBox();
            removeSelectedTeams = new Button();
            tournamentplayerslabel = new Label();
            tournamentteamslistbox = new ListBox();
            createprizebutton = new Button();
            addteambutton = new Button();
            createnewteamlink = new LinkLabel();
            selectTeamDropdown = new ComboBox();
            selecteamlabel = new Label();
            entryfee = new TextBox();
            entryfeelabel = new Label();
            tournamentnamevalue = new TextBox();
            tournamentnamelabel = new Label();
            createtournamentlabel = new Label();
            SuspendLayout();
            // 
            // createtournamentbutton
            // 
            createtournamentbutton.FlatAppearance.BorderColor = Color.Silver;
            createtournamentbutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createtournamentbutton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createtournamentbutton.FlatStyle = FlatStyle.Flat;
            createtournamentbutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createtournamentbutton.ForeColor = Color.DodgerBlue;
            createtournamentbutton.Location = new Point(279, 712);
            createtournamentbutton.Name = "createtournamentbutton";
            createtournamentbutton.Size = new Size(252, 72);
            createtournamentbutton.TabIndex = 43;
            createtournamentbutton.Text = "Create Tournament";
            createtournamentbutton.UseVisualStyleBackColor = true;
            createtournamentbutton.Click += createtournamentbutton_Click;
            // 
            // RemoveSelectedPrize
            // 
            RemoveSelectedPrize.FlatAppearance.BorderColor = Color.Silver;
            RemoveSelectedPrize.FlatAppearance.MouseDownBackColor = Color.DimGray;
            RemoveSelectedPrize.FlatAppearance.MouseOverBackColor = Color.LightGray;
            RemoveSelectedPrize.FlatStyle = FlatStyle.Flat;
            RemoveSelectedPrize.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveSelectedPrize.ForeColor = Color.DodgerBlue;
            RemoveSelectedPrize.Location = new Point(850, 514);
            RemoveSelectedPrize.Name = "RemoveSelectedPrize";
            RemoveSelectedPrize.Size = new Size(152, 92);
            RemoveSelectedPrize.TabIndex = 42;
            RemoveSelectedPrize.Text = "Remove Selected";
            RemoveSelectedPrize.UseVisualStyleBackColor = true;
            RemoveSelectedPrize.Click += RemoveSelectedPrize_Click;
            // 
            // prizeslbl
            // 
            prizeslbl.AutoSize = true;
            prizeslbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeslbl.ForeColor = Color.DodgerBlue;
            prizeslbl.Location = new Point(466, 413);
            prizeslbl.Name = "prizeslbl";
            prizeslbl.Size = new Size(85, 37);
            prizeslbl.TabIndex = 41;
            prizeslbl.Text = "Prizes";
            // 
            // prizeslistbox
            // 
            prizeslistbox.BorderStyle = BorderStyle.FixedSingle;
            prizeslistbox.FormattingEnabled = true;
            prizeslistbox.ItemHeight = 30;
            prizeslistbox.Location = new Point(466, 472);
            prizeslistbox.Name = "prizeslistbox";
            prizeslistbox.Size = new Size(359, 182);
            prizeslistbox.TabIndex = 40;
            // 
            // removeSelectedTeams
            // 
            removeSelectedTeams.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedTeams.FlatAppearance.MouseDownBackColor = Color.DimGray;
            removeSelectedTeams.FlatAppearance.MouseOverBackColor = Color.LightGray;
            removeSelectedTeams.FlatStyle = FlatStyle.Flat;
            removeSelectedTeams.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeSelectedTeams.ForeColor = Color.DodgerBlue;
            removeSelectedTeams.Location = new Point(850, 227);
            removeSelectedTeams.Name = "removeSelectedTeams";
            removeSelectedTeams.Size = new Size(152, 92);
            removeSelectedTeams.TabIndex = 39;
            removeSelectedTeams.Text = "Remove Selected";
            removeSelectedTeams.UseVisualStyleBackColor = true;
            removeSelectedTeams.Click += removeSelectedTeams_Click;
            // 
            // tournamentplayerslabel
            // 
            tournamentplayerslabel.AutoSize = true;
            tournamentplayerslabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentplayerslabel.ForeColor = Color.DodgerBlue;
            tournamentplayerslabel.Location = new Point(466, 130);
            tournamentplayerslabel.Name = "tournamentplayerslabel";
            tournamentplayerslabel.Size = new Size(198, 37);
            tournamentplayerslabel.TabIndex = 38;
            tournamentplayerslabel.Text = "Teams / Players";
            // 
            // tournamentteamslistbox
            // 
            tournamentteamslistbox.BorderStyle = BorderStyle.FixedSingle;
            tournamentteamslistbox.FormattingEnabled = true;
            tournamentteamslistbox.ItemHeight = 30;
            tournamentteamslistbox.Location = new Point(466, 189);
            tournamentteamslistbox.Name = "tournamentteamslistbox";
            tournamentteamslistbox.Size = new Size(359, 182);
            tournamentteamslistbox.TabIndex = 37;
            // 
            // createprizebutton
            // 
            createprizebutton.FlatAppearance.BorderColor = Color.Silver;
            createprizebutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createprizebutton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createprizebutton.FlatStyle = FlatStyle.Flat;
            createprizebutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createprizebutton.ForeColor = Color.DodgerBlue;
            createprizebutton.Location = new Point(141, 566);
            createprizebutton.Name = "createprizebutton";
            createprizebutton.Size = new Size(152, 49);
            createprizebutton.TabIndex = 36;
            createprizebutton.Text = "Create Prize";
            createprizebutton.UseVisualStyleBackColor = true;
            createprizebutton.Click += createprizebutton_Click;
            // 
            // addteambutton
            // 
            addteambutton.FlatAppearance.BorderColor = Color.Silver;
            addteambutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            addteambutton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            addteambutton.FlatStyle = FlatStyle.Flat;
            addteambutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addteambutton.ForeColor = Color.DodgerBlue;
            addteambutton.Location = new Point(141, 472);
            addteambutton.Name = "addteambutton";
            addteambutton.Size = new Size(152, 49);
            addteambutton.TabIndex = 35;
            addteambutton.Text = "Add Team";
            addteambutton.UseVisualStyleBackColor = true;
            addteambutton.Click += addteambutton_Click;
            // 
            // createnewteamlink
            // 
            createnewteamlink.AutoSize = true;
            createnewteamlink.Location = new Point(217, 358);
            createnewteamlink.Name = "createnewteamlink";
            createnewteamlink.Size = new Size(121, 30);
            createnewteamlink.TabIndex = 34;
            createnewteamlink.TabStop = true;
            createnewteamlink.Text = "Create New";
            createnewteamlink.LinkClicked += createnewteamlink_LinkClicked;
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(50, 391);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(288, 38);
            selectTeamDropdown.TabIndex = 33;
            // 
            // selecteamlabel
            // 
            selecteamlabel.AutoSize = true;
            selecteamlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selecteamlabel.ForeColor = Color.DodgerBlue;
            selecteamlabel.Location = new Point(44, 341);
            selecteamlabel.Name = "selecteamlabel";
            selecteamlabel.Size = new Size(156, 37);
            selecteamlabel.TabIndex = 32;
            selecteamlabel.Text = "Select Team";
            // 
            // entryfee
            // 
            entryfee.BorderStyle = BorderStyle.FixedSingle;
            entryfee.Location = new Point(200, 264);
            entryfee.Name = "entryfee";
            entryfee.Size = new Size(138, 35);
            entryfee.TabIndex = 31;
            entryfee.Text = "0";
            // 
            // entryfeelabel
            // 
            entryfeelabel.AutoSize = true;
            entryfeelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryfeelabel.ForeColor = Color.DodgerBlue;
            entryfeelabel.Location = new Point(39, 260);
            entryfeelabel.Name = "entryfeelabel";
            entryfeelabel.Size = new Size(125, 37);
            entryfeelabel.TabIndex = 30;
            entryfeelabel.Text = "Entry Fee";
            // 
            // tournamentnamevalue
            // 
            tournamentnamevalue.BorderStyle = BorderStyle.FixedSingle;
            tournamentnamevalue.Location = new Point(50, 191);
            tournamentnamevalue.Name = "tournamentnamevalue";
            tournamentnamevalue.Size = new Size(298, 35);
            tournamentnamevalue.TabIndex = 29;
            // 
            // tournamentnamelabel
            // 
            tournamentnamelabel.AutoSize = true;
            tournamentnamelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentnamelabel.ForeColor = Color.DodgerBlue;
            tournamentnamelabel.Location = new Point(39, 130);
            tournamentnamelabel.Name = "tournamentnamelabel";
            tournamentnamelabel.Size = new Size(236, 37);
            tournamentnamelabel.TabIndex = 28;
            tournamentnamelabel.Text = "Tournament Name";
            // 
            // createtournamentlabel
            // 
            createtournamentlabel.AutoSize = true;
            createtournamentlabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createtournamentlabel.ForeColor = Color.DodgerBlue;
            createtournamentlabel.Location = new Point(26, 34);
            createtournamentlabel.Name = "createtournamentlabel";
            createtournamentlabel.Size = new Size(334, 50);
            createtournamentlabel.TabIndex = 27;
            createtournamentlabel.Text = "Create Tournament";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1044, 799);
            Controls.Add(createtournamentbutton);
            Controls.Add(RemoveSelectedPrize);
            Controls.Add(prizeslbl);
            Controls.Add(prizeslistbox);
            Controls.Add(removeSelectedTeams);
            Controls.Add(tournamentplayerslabel);
            Controls.Add(tournamentteamslistbox);
            Controls.Add(createprizebutton);
            Controls.Add(addteambutton);
            Controls.Add(createnewteamlink);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selecteamlabel);
            Controls.Add(entryfee);
            Controls.Add(entryfeelabel);
            Controls.Add(tournamentnamevalue);
            Controls.Add(tournamentnamelabel);
            Controls.Add(createtournamentlabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createtournamentbutton;
        private Button RemoveSelectedPrize;
        private Label prizeslbl;
        private ListBox prizeslistbox;
        private Button removeSelectedTeams;
        private Label tournamentplayerslabel;
        private ListBox tournamentteamslistbox;
        private Button createprizebutton;
        private Button addteambutton;
        private LinkLabel createnewteamlink;
        private ComboBox selectTeamDropdown;
        private Label selecteamlabel;
        private TextBox entryfee;
        private Label entryfeelabel;
        private TextBox tournamentnamevalue;
        private Label tournamentnamelabel;
        private Label createtournamentlabel;
    }
}