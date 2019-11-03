﻿namespace CafeteriaManagement
{
    partial class UCQueueBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.trackBarSongDuration = new System.Windows.Forms.TrackBar();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageQueue = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNextUp = new System.Windows.Forms.Label();
            this.dataGridViewNextUp = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewPlaying = new System.Windows.Forms.DataGridView();
            this.labelPlaying = new System.Windows.Forms.Label();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPlayQueue = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSongDuration)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageQueue.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNextUp)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).BeginInit();
            this.tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.labelDuration);
            this.panelControl.Controls.Add(this.labelTime);
            this.panelControl.Controls.Add(this.trackBarSongDuration);
            this.panelControl.Controls.Add(this.buttonNext);
            this.panelControl.Controls.Add(this.buttonPrevious);
            this.panelControl.Controls.Add(this.buttonPlay);
            this.panelControl.Controls.Add(this.buttonPause);
            this.panelControl.Location = new System.Drawing.Point(3, 396);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(822, 112);
            this.panelControl.TabIndex = 7;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(689, 68);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(22, 17);
            this.labelDuration.TabIndex = 8;
            this.labelDuration.Text = "-:-";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(125, 68);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(22, 17);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "-:-";
            // 
            // trackBarSongDuration
            // 
            this.trackBarSongDuration.Enabled = false;
            this.trackBarSongDuration.LargeChange = 0;
            this.trackBarSongDuration.Location = new System.Drawing.Point(175, 49);
            this.trackBarSongDuration.Name = "trackBarSongDuration";
            this.trackBarSongDuration.Size = new System.Drawing.Size(497, 45);
            this.trackBarSongDuration.SmallChange = 0;
            this.trackBarSongDuration.TabIndex = 6;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(484, 20);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(266, 20);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "Prev";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(373, 20);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(373, 20);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 348);
            this.panel2.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageQueue);
            this.tabControl1.Controls.Add(this.tabPageHistory);
            this.tabControl1.Location = new System.Drawing.Point(11, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageQueue
            // 
            this.tabPageQueue.Controls.Add(this.panel4);
            this.tabPageQueue.Controls.Add(this.panel3);
            this.tabPageQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQueue.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueue.Name = "tabPageQueue";
            this.tabPageQueue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQueue.Size = new System.Drawing.Size(800, 316);
            this.tabPageQueue.TabIndex = 0;
            this.tabPageQueue.Text = "Queue";
            this.tabPageQueue.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelNextUp);
            this.panel4.Controls.Add(this.dataGridViewNextUp);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(6, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 191);
            this.panel4.TabIndex = 1;
            // 
            // labelNextUp
            // 
            this.labelNextUp.AutoSize = true;
            this.labelNextUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextUp.Location = new System.Drawing.Point(3, 13);
            this.labelNextUp.Name = "labelNextUp";
            this.labelNextUp.Size = new System.Drawing.Size(65, 17);
            this.labelNextUp.TabIndex = 1;
            this.labelNextUp.Text = "Next Up";
            // 
            // dataGridViewNextUp
            // 
            this.dataGridViewNextUp.AllowUserToAddRows = false;
            this.dataGridViewNextUp.AllowUserToDeleteRows = false;
            this.dataGridViewNextUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNextUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNextUp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNextUp.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewNextUp.Name = "dataGridViewNextUp";
            this.dataGridViewNextUp.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNextUp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNextUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNextUp.Size = new System.Drawing.Size(776, 144);
            this.dataGridViewNextUp.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewPlaying);
            this.panel3.Controls.Add(this.labelPlaying);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 107);
            this.panel3.TabIndex = 0;
            // 
            // dataGridViewPlaying
            // 
            this.dataGridViewPlaying.AllowUserToAddRows = false;
            this.dataGridViewPlaying.AllowUserToDeleteRows = false;
            this.dataGridViewPlaying.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlaying.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPlaying.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPlaying.Location = new System.Drawing.Point(6, 40);
            this.dataGridViewPlaying.Name = "dataGridViewPlaying";
            this.dataGridViewPlaying.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlaying.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPlaying.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlaying.Size = new System.Drawing.Size(779, 64);
            this.dataGridViewPlaying.TabIndex = 1;
            // 
            // labelPlaying
            // 
            this.labelPlaying.AutoSize = true;
            this.labelPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaying.Location = new System.Drawing.Point(3, 9);
            this.labelPlaying.Name = "labelPlaying";
            this.labelPlaying.Size = new System.Drawing.Size(96, 17);
            this.labelPlaying.TabIndex = 0;
            this.labelPlaying.Text = "Now Playing";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.dataGridViewHistory);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(800, 316);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewHistory.Location = new System.Drawing.Point(11, 53);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(783, 257);
            this.dataGridViewHistory.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPlayQueue);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 33);
            this.panel1.TabIndex = 5;
            // 
            // labelPlayQueue
            // 
            this.labelPlayQueue.AutoSize = true;
            this.labelPlayQueue.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayQueue.Location = new System.Drawing.Point(9, 1);
            this.labelPlayQueue.Name = "labelPlayQueue";
            this.labelPlayQueue.Size = new System.Drawing.Size(164, 32);
            this.labelPlayQueue.TabIndex = 0;
            this.labelPlayQueue.Text = "Play Queue";
            // 
            // UCQueueBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCQueueBox";
            this.Size = new System.Drawing.Size(828, 512);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSongDuration)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageQueue.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNextUp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaying)).EndInit();
            this.tabPageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TrackBar trackBarSongDuration;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageQueue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelNextUp;
        private System.Windows.Forms.DataGridView dataGridViewNextUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewPlaying;
        private System.Windows.Forms.Label labelPlaying;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPlayQueue;
        private System.Windows.Forms.Button buttonPause;
    }
}
