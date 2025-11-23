namespace TrackerrUi
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            creasteteambtn = new Button();
            createteamlabel = new Label();
            createteambtn = new Button();
            deleteselectedmemberbtn = new Button();
            teammemberslistbox = new ListBox();
            addnewmembergp = new GroupBox();
            creatememberbtn = new Button();
            cellphonevalue = new TextBox();
            celphonelbl = new Label();
            emailvalue = new TextBox();
            emaillbl = new Label();
            lastnamevalue = new TextBox();
            Lastnamelabel = new Label();
            firstnamevalue = new TextBox();
            firstnamelabel = new Label();
            addmemberbutton = new Button();
            selectteamlabel = new Label();
            teamnamelabel = new Label();
            label1 = new Label();
            selecteamdropdown = new ComboBox();
            selectteammemberdropdown = new ComboBox();
            addnewmembergp.SuspendLayout();
            SuspendLayout();
            // 
            // creasteteambtn
            // 
            creasteteambtn.FlatAppearance.BorderColor = Color.Silver;
            creasteteambtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            creasteteambtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            creasteteambtn.FlatStyle = FlatStyle.Flat;
            creasteteambtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            creasteteambtn.ForeColor = Color.DodgerBlue;
            creasteteambtn.Location = new Point(636, 1406);
            creasteteambtn.Margin = new Padding(5, 6, 5, 6);
            creasteteambtn.Name = "creasteteambtn";
            creasteteambtn.Size = new Size(432, 144);
            creasteteambtn.TabIndex = 37;
            creasteteambtn.Text = "Create Team";
            creasteteambtn.UseVisualStyleBackColor = true;
            // 
            // createteamlabel
            // 
            createteamlabel.AutoSize = true;
            createteamlabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createteamlabel.ForeColor = Color.DodgerBlue;
            createteamlabel.Location = new Point(-19, -128);
            createteamlabel.Margin = new Padding(5, 0, 5, 0);
            createteamlabel.Name = "createteamlabel";
            createteamlabel.Size = new Size(223, 50);
            createteamlabel.TabIndex = 28;
            createteamlabel.Text = "Create Team";
            // 
            // createteambtn
            // 
            createteambtn.FlatAppearance.BorderColor = Color.Silver;
            createteambtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createteambtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createteambtn.FlatStyle = FlatStyle.Flat;
            createteambtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createteambtn.ForeColor = Color.DodgerBlue;
            createteambtn.Location = new Point(424, 792);
            createteambtn.Name = "createteambtn";
            createteambtn.Size = new Size(252, 72);
            createteambtn.TabIndex = 47;
            createteambtn.Text = "Create Team";
            createteambtn.UseVisualStyleBackColor = true;
            // 
            // deleteselectedmemberbtn
            // 
            deleteselectedmemberbtn.FlatAppearance.BorderColor = Color.Silver;
            deleteselectedmemberbtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            deleteselectedmemberbtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            deleteselectedmemberbtn.FlatStyle = FlatStyle.Flat;
            deleteselectedmemberbtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteselectedmemberbtn.ForeColor = Color.DodgerBlue;
            deleteselectedmemberbtn.Location = new Point(924, 353);
            deleteselectedmemberbtn.Name = "deleteselectedmemberbtn";
            deleteselectedmemberbtn.Size = new Size(152, 92);
            deleteselectedmemberbtn.TabIndex = 46;
            deleteselectedmemberbtn.Text = "Delete Selected";
            deleteselectedmemberbtn.UseVisualStyleBackColor = true;
            deleteselectedmemberbtn.Click += deleteselectedmemberbtn_Click;
            // 
            // teammemberslistbox
            // 
            teammemberslistbox.BorderStyle = BorderStyle.FixedSingle;
            teammemberslistbox.FormattingEnabled = true;
            teammemberslistbox.ItemHeight = 30;
            teammemberslistbox.Location = new Point(543, 175);
            teammemberslistbox.Name = "teammemberslistbox";
            teammemberslistbox.Size = new Size(359, 572);
            teammemberslistbox.TabIndex = 45;
            // 
            // addnewmembergp
            // 
            addnewmembergp.Controls.Add(creatememberbtn);
            addnewmembergp.Controls.Add(cellphonevalue);
            addnewmembergp.Controls.Add(celphonelbl);
            addnewmembergp.Controls.Add(emailvalue);
            addnewmembergp.Controls.Add(emaillbl);
            addnewmembergp.Controls.Add(lastnamevalue);
            addnewmembergp.Controls.Add(Lastnamelabel);
            addnewmembergp.Controls.Add(firstnamevalue);
            addnewmembergp.Controls.Add(firstnamelabel);
            addnewmembergp.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addnewmembergp.ForeColor = Color.DodgerBlue;
            addnewmembergp.Location = new Point(55, 446);
            addnewmembergp.Name = "addnewmembergp";
            addnewmembergp.Size = new Size(419, 319);
            addnewmembergp.TabIndex = 44;
            addnewmembergp.TabStop = false;
            addnewmembergp.Text = "Add New Member";
            // 
            // creatememberbtn
            // 
            creatememberbtn.FlatAppearance.BorderColor = Color.Silver;
            creatememberbtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            creatememberbtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            creatememberbtn.FlatStyle = FlatStyle.Flat;
            creatememberbtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            creatememberbtn.ForeColor = Color.DodgerBlue;
            creatememberbtn.Location = new Point(106, 253);
            creatememberbtn.Name = "creatememberbtn";
            creatememberbtn.Size = new Size(192, 49);
            creatememberbtn.TabIndex = 21;
            creatememberbtn.Text = "Create Member";
            creatememberbtn.UseVisualStyleBackColor = true;
            creatememberbtn.Click += creatememberbtn_Click;
            // 
            // cellphonevalue
            // 
            cellphonevalue.BorderStyle = BorderStyle.FixedSingle;
            cellphonevalue.Location = new Point(161, 200);
            cellphonevalue.Name = "cellphonevalue";
            cellphonevalue.Size = new Size(180, 43);
            cellphonevalue.TabIndex = 18;
            // 
            // celphonelbl
            // 
            celphonelbl.AutoSize = true;
            celphonelbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            celphonelbl.ForeColor = Color.DodgerBlue;
            celphonelbl.Location = new Point(11, 200);
            celphonelbl.Name = "celphonelbl";
            celphonelbl.Size = new Size(138, 37);
            celphonelbl.TabIndex = 17;
            celphonelbl.Text = "Cellphone";
            // 
            // emailvalue
            // 
            emailvalue.BorderStyle = BorderStyle.FixedSingle;
            emailvalue.Location = new Point(161, 151);
            emailvalue.Name = "emailvalue";
            emailvalue.Size = new Size(180, 43);
            emailvalue.TabIndex = 16;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emaillbl.ForeColor = Color.DodgerBlue;
            emaillbl.Location = new Point(11, 153);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(82, 37);
            emaillbl.TabIndex = 15;
            emaillbl.Text = "Email";
            // 
            // lastnamevalue
            // 
            lastnamevalue.BorderStyle = BorderStyle.FixedSingle;
            lastnamevalue.Location = new Point(161, 104);
            lastnamevalue.Name = "lastnamevalue";
            lastnamevalue.Size = new Size(180, 43);
            lastnamevalue.TabIndex = 14;
            // 
            // Lastnamelabel
            // 
            Lastnamelabel.AutoSize = true;
            Lastnamelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lastnamelabel.ForeColor = Color.DodgerBlue;
            Lastnamelabel.Location = new Point(13, 106);
            Lastnamelabel.Name = "Lastnamelabel";
            Lastnamelabel.Size = new Size(142, 37);
            Lastnamelabel.TabIndex = 13;
            Lastnamelabel.Text = "Last Name";
            // 
            // firstnamevalue
            // 
            firstnamevalue.BorderStyle = BorderStyle.FixedSingle;
            firstnamevalue.Location = new Point(161, 53);
            firstnamevalue.Name = "firstnamevalue";
            firstnamevalue.Size = new Size(180, 43);
            firstnamevalue.TabIndex = 12;
            // 
            // firstnamelabel
            // 
            firstnamelabel.AutoSize = true;
            firstnamelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnamelabel.ForeColor = Color.DodgerBlue;
            firstnamelabel.Location = new Point(11, 59);
            firstnamelabel.Name = "firstnamelabel";
            firstnamelabel.Size = new Size(144, 37);
            firstnamelabel.TabIndex = 11;
            firstnamelabel.Text = "First Name";
            // 
            // addmemberbutton
            // 
            addmemberbutton.FlatAppearance.BorderColor = Color.Silver;
            addmemberbutton.FlatAppearance.MouseDownBackColor = Color.DimGray;
            addmemberbutton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            addmemberbutton.FlatStyle = FlatStyle.Flat;
            addmemberbutton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addmemberbutton.ForeColor = Color.DodgerBlue;
            addmemberbutton.Location = new Point(161, 364);
            addmemberbutton.Name = "addmemberbutton";
            addmemberbutton.Size = new Size(192, 49);
            addmemberbutton.TabIndex = 43;
            addmemberbutton.Text = "Add Member";
            addmemberbutton.UseVisualStyleBackColor = true;
            addmemberbutton.Click += addmemberbutton_Click;
            // 
            // selectteamlabel
            // 
            selectteamlabel.AutoSize = true;
            selectteamlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectteamlabel.ForeColor = Color.DodgerBlue;
            selectteamlabel.Location = new Point(55, 234);
            selectteamlabel.Name = "selectteamlabel";
            selectteamlabel.Size = new Size(263, 37);
            selectteamlabel.TabIndex = 41;
            selectteamlabel.Text = "Select Team Member";
            // 
            // teamnamelabel
            // 
            teamnamelabel.AutoSize = true;
            teamnamelabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamnamelabel.ForeColor = Color.DodgerBlue;
            teamnamelabel.Location = new Point(55, 112);
            teamnamelabel.Name = "teamnamelabel";
            teamnamelabel.Size = new Size(157, 37);
            teamnamelabel.TabIndex = 39;
            teamnamelabel.Text = "Team Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(42, 25);
            label1.Name = "label1";
            label1.Size = new Size(223, 50);
            label1.TabIndex = 38;
            label1.Text = "Create Team";
            // 
            // selecteamdropdown
            // 
            selecteamdropdown.FormattingEnabled = true;
            selecteamdropdown.Location = new Point(56, 175);
            selecteamdropdown.Name = "selecteamdropdown";
            selecteamdropdown.Size = new Size(310, 38);
            selecteamdropdown.TabIndex = 48;
            // 
            // selectteammemberdropdown
            // 
            selectteammemberdropdown.FormattingEnabled = true;
            selectteammemberdropdown.Location = new Point(56, 283);
            selectteammemberdropdown.Name = "selectteammemberdropdown";
            selectteammemberdropdown.Size = new Size(310, 38);
            selectteammemberdropdown.TabIndex = 49;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 890);
            Controls.Add(selectteammemberdropdown);
            Controls.Add(selecteamdropdown);
            Controls.Add(createteambtn);
            Controls.Add(deleteselectedmemberbtn);
            Controls.Add(teammemberslistbox);
            Controls.Add(addnewmembergp);
            Controls.Add(addmemberbutton);
            Controls.Add(selectteamlabel);
            Controls.Add(teamnamelabel);
            Controls.Add(label1);
            Controls.Add(creasteteambtn);
            Controls.Add(createteamlabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addnewmembergp.ResumeLayout(false);
            addnewmembergp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button creasteteambtn;
        private Label createteamlabel;
        private Button createteambtn;
        private Button deleteselectedmemberbtn;
        private ListBox teammemberslistbox;
        private GroupBox addnewmembergp;
        private Button creatememberbtn;
        private TextBox cellphonevalue;
        private Label celphonelbl;
        private TextBox emailvalue;
        private Label emaillbl;
        private TextBox lastnamevalue;
        private Label Lastnamelabel;
        private TextBox firstnamevalue;
        private Label firstnamelabel;
        private Button addmemberbutton;
        private Label selectteamlabel;
        private Label teamnamelabel;
        private Label label1;
        private ComboBox selecteamdropdown;
        private ComboBox selectteammemberdropdown;
    }
}