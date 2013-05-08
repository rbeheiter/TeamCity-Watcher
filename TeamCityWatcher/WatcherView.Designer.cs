namespace TeamCityWatcher
{
    partial class WatcherView
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
            this.projectGridView = new System.Windows.Forms.DataGridView();
            this.ProjectsGroup = new System.Windows.Forms.GroupBox();
            this.BuildsGroup = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearStillFailingSoundButton = new System.Windows.Forms.Button();
            this.pickStillFailingSoundButton = new System.Windows.Forms.Button();
            this.playStillFailingSoundButton = new System.Windows.Forms.Button();
            this.buildGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFailureSoundButton = new System.Windows.Forms.Button();
            this.pickFailureSoundButton = new System.Windows.Forms.Button();
            this.playFailureSoundButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearFixedSoundButton = new System.Windows.Forms.Button();
            this.pickFixedSoundButton = new System.Windows.Forms.Button();
            this.playFixedSoundButton = new System.Windows.Forms.Button();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.updateButton = new System.Windows.Forms.Button();
            this.UpdateIntervalBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).BeginInit();
            this.ProjectsGroup.SuspendLayout();
            this.BuildsGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectGridView
            // 
            this.projectGridView.AllowUserToAddRows = false;
            this.projectGridView.AllowUserToDeleteRows = false;
            this.projectGridView.AllowUserToResizeRows = false;
            this.projectGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectGridView.Location = new System.Drawing.Point(3, 16);
            this.projectGridView.Name = "projectGridView";
            this.projectGridView.ReadOnly = true;
            this.projectGridView.RowHeadersVisible = false;
            this.projectGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.projectGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectGridView.Size = new System.Drawing.Size(1018, 275);
            this.projectGridView.TabIndex = 1;
            this.projectGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectClick);
            // 
            // ProjectsGroup
            // 
            this.ProjectsGroup.AutoSize = true;
            this.ProjectsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProjectsGroup.Controls.Add(this.projectGridView);
            this.ProjectsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectsGroup.Location = new System.Drawing.Point(0, 0);
            this.ProjectsGroup.Name = "ProjectsGroup";
            this.ProjectsGroup.Size = new System.Drawing.Size(1024, 294);
            this.ProjectsGroup.TabIndex = 2;
            this.ProjectsGroup.TabStop = false;
            this.ProjectsGroup.Text = "Projects";
            // 
            // BuildsGroup
            // 
            this.BuildsGroup.AutoSize = true;
            this.BuildsGroup.Controls.Add(this.groupBox3);
            this.BuildsGroup.Controls.Add(this.buildGridView);
            this.BuildsGroup.Controls.Add(this.groupBox1);
            this.BuildsGroup.Controls.Add(this.groupBox2);
            this.BuildsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuildsGroup.Location = new System.Drawing.Point(0, 294);
            this.BuildsGroup.Name = "BuildsGroup";
            this.BuildsGroup.Size = new System.Drawing.Size(1024, 294);
            this.BuildsGroup.TabIndex = 3;
            this.BuildsGroup.TabStop = false;
            this.BuildsGroup.Text = "Builds";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearStillFailingSoundButton);
            this.groupBox3.Controls.Add(this.pickStillFailingSoundButton);
            this.groupBox3.Controls.Add(this.playStillFailingSoundButton);
            this.groupBox3.Location = new System.Drawing.Point(586, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Still Failing Sound";
            // 
            // clearStillFailingSoundButton
            // 
            this.clearStillFailingSoundButton.Location = new System.Drawing.Point(142, 15);
            this.clearStillFailingSoundButton.Name = "clearStillFailingSoundButton";
            this.clearStillFailingSoundButton.Size = new System.Drawing.Size(60, 23);
            this.clearStillFailingSoundButton.TabIndex = 7;
            this.clearStillFailingSoundButton.Text = "Clear";
            this.clearStillFailingSoundButton.UseVisualStyleBackColor = true;
            this.clearStillFailingSoundButton.Click += new System.EventHandler(this.clearStillFailingSoundButton_Click);
            // 
            // pickStillFailingSoundButton
            // 
            this.pickStillFailingSoundButton.Location = new System.Drawing.Point(10, 15);
            this.pickStillFailingSoundButton.Name = "pickStillFailingSoundButton";
            this.pickStillFailingSoundButton.Size = new System.Drawing.Size(60, 23);
            this.pickStillFailingSoundButton.TabIndex = 5;
            this.pickStillFailingSoundButton.Text = "Pick File";
            this.pickStillFailingSoundButton.UseVisualStyleBackColor = true;
            this.pickStillFailingSoundButton.Click += new System.EventHandler(this.pickStillFailingSoundButton_Click);
            // 
            // playStillFailingSoundButton
            // 
            this.playStillFailingSoundButton.Location = new System.Drawing.Point(76, 15);
            this.playStillFailingSoundButton.Name = "playStillFailingSoundButton";
            this.playStillFailingSoundButton.Size = new System.Drawing.Size(60, 23);
            this.playStillFailingSoundButton.TabIndex = 4;
            this.playStillFailingSoundButton.Text = "Play File";
            this.playStillFailingSoundButton.UseVisualStyleBackColor = true;
            this.playStillFailingSoundButton.Click += new System.EventHandler(this.playStillFailingSoundButton_Click);
            // 
            // buildGridView
            // 
            this.buildGridView.AllowUserToAddRows = false;
            this.buildGridView.AllowUserToDeleteRows = false;
            this.buildGridView.AllowUserToResizeColumns = false;
            this.buildGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buildGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buildGridView.Location = new System.Drawing.Point(3, 16);
            this.buildGridView.Name = "buildGridView";
            this.buildGridView.ReadOnly = true;
            this.buildGridView.RowHeadersVisible = false;
            this.buildGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buildGridView.Size = new System.Drawing.Size(1018, 206);
            this.buildGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearFailureSoundButton);
            this.groupBox1.Controls.Add(this.pickFailureSoundButton);
            this.groupBox1.Controls.Add(this.playFailureSoundButton);
            this.groupBox1.Location = new System.Drawing.Point(370, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Failure Sound";
            // 
            // clearFailureSoundButton
            // 
            this.clearFailureSoundButton.Location = new System.Drawing.Point(142, 15);
            this.clearFailureSoundButton.Name = "clearFailureSoundButton";
            this.clearFailureSoundButton.Size = new System.Drawing.Size(60, 23);
            this.clearFailureSoundButton.TabIndex = 6;
            this.clearFailureSoundButton.Text = "Clear";
            this.clearFailureSoundButton.UseVisualStyleBackColor = true;
            this.clearFailureSoundButton.Click += new System.EventHandler(this.clearFailureSoundButton_Click);
            // 
            // pickFailureSoundButton
            // 
            this.pickFailureSoundButton.Location = new System.Drawing.Point(10, 15);
            this.pickFailureSoundButton.Name = "pickFailureSoundButton";
            this.pickFailureSoundButton.Size = new System.Drawing.Size(60, 23);
            this.pickFailureSoundButton.TabIndex = 5;
            this.pickFailureSoundButton.Text = "Pick File";
            this.pickFailureSoundButton.UseVisualStyleBackColor = true;
            this.pickFailureSoundButton.Click += new System.EventHandler(this.pickFailedSoundButton_Click);
            // 
            // playFailureSoundButton
            // 
            this.playFailureSoundButton.Location = new System.Drawing.Point(76, 15);
            this.playFailureSoundButton.Name = "playFailureSoundButton";
            this.playFailureSoundButton.Size = new System.Drawing.Size(60, 23);
            this.playFailureSoundButton.TabIndex = 4;
            this.playFailureSoundButton.Text = "Play File";
            this.playFailureSoundButton.UseVisualStyleBackColor = true;
            this.playFailureSoundButton.Click += new System.EventHandler(this.playFailedSoundButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearFixedSoundButton);
            this.groupBox2.Controls.Add(this.pickFixedSoundButton);
            this.groupBox2.Controls.Add(this.playFixedSoundButton);
            this.groupBox2.Location = new System.Drawing.Point(802, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 44);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fixed Sound";
            // 
            // clearFixedSoundButton
            // 
            this.clearFixedSoundButton.Location = new System.Drawing.Point(142, 15);
            this.clearFixedSoundButton.Name = "clearFixedSoundButton";
            this.clearFixedSoundButton.Size = new System.Drawing.Size(60, 23);
            this.clearFixedSoundButton.TabIndex = 8;
            this.clearFixedSoundButton.Text = "Clear";
            this.clearFixedSoundButton.UseVisualStyleBackColor = true;
            this.clearFixedSoundButton.Click += new System.EventHandler(this.clearFixedSoundButton_Click);
            // 
            // pickFixedSoundButton
            // 
            this.pickFixedSoundButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pickFixedSoundButton.Location = new System.Drawing.Point(10, 15);
            this.pickFixedSoundButton.Name = "pickFixedSoundButton";
            this.pickFixedSoundButton.Size = new System.Drawing.Size(60, 23);
            this.pickFixedSoundButton.TabIndex = 5;
            this.pickFixedSoundButton.Text = "Pick File";
            this.pickFixedSoundButton.UseVisualStyleBackColor = true;
            this.pickFixedSoundButton.Click += new System.EventHandler(this.pickFixedSoundButton_Click);
            // 
            // playFixedSoundButton
            // 
            this.playFixedSoundButton.Location = new System.Drawing.Point(76, 15);
            this.playFixedSoundButton.Name = "playFixedSoundButton";
            this.playFixedSoundButton.Size = new System.Drawing.Size(60, 23);
            this.playFixedSoundButton.TabIndex = 4;
            this.playFixedSoundButton.Text = "Play File";
            this.playFixedSoundButton.UseVisualStyleBackColor = true;
            this.playFixedSoundButton.Click += new System.EventHandler(this.playFixedSoundButton_Click);
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(200, 537);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(100, 24);
            this.LoadingLabel.TabIndex = 3;
            this.LoadingLabel.Text = "Updating...";
            this.LoadingLabel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "wav";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Sound Files (*.wav)|*.wav|All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(119, 540);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateIntervalBox
            // 
            this.UpdateIntervalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UpdateIntervalBox.Location = new System.Drawing.Point(13, 545);
            this.UpdateIntervalBox.Name = "UpdateIntervalBox";
            this.UpdateIntervalBox.ReadOnly = true;
            this.UpdateIntervalBox.Size = new System.Drawing.Size(100, 13);
            this.UpdateIntervalBox.TabIndex = 3;
            // 
            // WatcherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 580);
            this.Controls.Add(this.UpdateIntervalBox);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.BuildsGroup);
            this.Controls.Add(this.ProjectsGroup);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WatcherView";
            this.Text = "TeamCity Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).EndInit();
            this.ProjectsGroup.ResumeLayout(false);
            this.BuildsGroup.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buildGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectGridView;
        private System.Windows.Forms.GroupBox ProjectsGroup;
        private System.Windows.Forms.GroupBox BuildsGroup;
        private System.Windows.Forms.DataGridView buildGridView;
        private System.Windows.Forms.Button playFailureSoundButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pickFailureSoundButton;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button pickFixedSoundButton;
        private System.Windows.Forms.Button playFixedSoundButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox UpdateIntervalBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button pickStillFailingSoundButton;
        private System.Windows.Forms.Button playStillFailingSoundButton;
        private System.Windows.Forms.Button clearFailureSoundButton;
        private System.Windows.Forms.Button clearStillFailingSoundButton;
        private System.Windows.Forms.Button clearFixedSoundButton;

    }
}

