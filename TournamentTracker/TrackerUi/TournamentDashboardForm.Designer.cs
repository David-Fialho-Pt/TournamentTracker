namespace TrackerrUi
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            createtournamentbtn = new Button();
            loadtournamentbtn = new Button();
            loadexistingtournamentdropdown = new TextBox();
            loadexistingtournamenlbl = new Label();
            dashboardlbl = new Label();
            SuspendLayout();
            // 
            // createtournamentbtn
            // 
            createtournamentbtn.FlatAppearance.BorderColor = Color.Silver;
            createtournamentbtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            createtournamentbtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            createtournamentbtn.FlatStyle = FlatStyle.Flat;
            createtournamentbtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createtournamentbtn.ForeColor = Color.DodgerBlue;
            createtournamentbtn.Location = new Point(94, 320);
            createtournamentbtn.Name = "createtournamentbtn";
            createtournamentbtn.Size = new Size(314, 72);
            createtournamentbtn.TabIndex = 33;
            createtournamentbtn.Text = "Create Tournament";
            createtournamentbtn.UseVisualStyleBackColor = true;
            // 
            // loadtournamentbtn
            // 
            loadtournamentbtn.FlatAppearance.BorderColor = Color.Silver;
            loadtournamentbtn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            loadtournamentbtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            loadtournamentbtn.FlatStyle = FlatStyle.Flat;
            loadtournamentbtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadtournamentbtn.ForeColor = Color.DodgerBlue;
            loadtournamentbtn.Location = new Point(121, 225);
            loadtournamentbtn.Name = "loadtournamentbtn";
            loadtournamentbtn.Size = new Size(260, 72);
            loadtournamentbtn.TabIndex = 32;
            loadtournamentbtn.Text = "Load Tournament";
            loadtournamentbtn.UseVisualStyleBackColor = true;
            // 
            // loadexistingtournamentdropdown
            // 
            loadexistingtournamentdropdown.BorderStyle = BorderStyle.FixedSingle;
            loadexistingtournamentdropdown.Location = new Point(42, 167);
            loadexistingtournamentdropdown.Name = "loadexistingtournamentdropdown";
            loadexistingtournamentdropdown.Size = new Size(418, 35);
            loadexistingtournamentdropdown.TabIndex = 31;
            // 
            // loadexistingtournamenlbl
            // 
            loadexistingtournamenlbl.AutoSize = true;
            loadexistingtournamenlbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadexistingtournamenlbl.ForeColor = Color.DodgerBlue;
            loadexistingtournamenlbl.Location = new Point(90, 107);
            loadexistingtournamenlbl.Name = "loadexistingtournamenlbl";
            loadexistingtournamenlbl.Size = new Size(322, 37);
            loadexistingtournamenlbl.TabIndex = 30;
            loadexistingtournamenlbl.Text = "Load Existing Tournament";
            // 
            // dashboardlbl
            // 
            dashboardlbl.AutoSize = true;
            dashboardlbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardlbl.ForeColor = Color.DodgerBlue;
            dashboardlbl.Location = new Point(47, 34);
            dashboardlbl.Name = "dashboardlbl";
            dashboardlbl.Size = new Size(408, 50);
            dashboardlbl.TabIndex = 29;
            dashboardlbl.Text = "Tournament Dashboard";
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 430);
            Controls.Add(createtournamentbtn);
            Controls.Add(loadtournamentbtn);
            Controls.Add(loadexistingtournamentdropdown);
            Controls.Add(loadexistingtournamenlbl);
            Controls.Add(dashboardlbl);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createtournamentbtn;
        private Button loadtournamentbtn;
        private TextBox loadexistingtournamentdropdown;
        private Label loadexistingtournamenlbl;
        private Label dashboardlbl;
    }
}