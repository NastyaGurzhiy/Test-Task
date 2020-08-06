namespace TestTask_WF
{
    partial class History
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
            this.txbHistory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbForAllTime = new System.Windows.Forms.RadioButton();
            this.rdbForDay = new System.Windows.Forms.RadioButton();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbHistory
            // 
            this.txbHistory.AcceptsReturn = true;
            this.txbHistory.AcceptsTab = true;
            this.txbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbHistory.Location = new System.Drawing.Point(22, 57);
            this.txbHistory.Multiline = true;
            this.txbHistory.Name = "txbHistory";
            this.txbHistory.ReadOnly = true;
            this.txbHistory.Size = new System.Drawing.Size(480, 172);
            this.txbHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your history:";
            // 
            // rdbForAllTime
            // 
            this.rdbForAllTime.AutoSize = true;
            this.rdbForAllTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbForAllTime.Location = new System.Drawing.Point(176, 241);
            this.rdbForAllTime.Name = "rdbForAllTime";
            this.rdbForAllTime.Size = new System.Drawing.Size(131, 20);
            this.rdbForAllTime.TabIndex = 14;
            this.rdbForAllTime.TabStop = true;
            this.rdbForAllTime.Text = "History for all time";
            this.rdbForAllTime.UseVisualStyleBackColor = true;
            // 
            // rdbForDay
            // 
            this.rdbForDay.AutoSize = true;
            this.rdbForDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbForDay.Location = new System.Drawing.Point(50, 241);
            this.rdbForDay.Name = "rdbForDay";
            this.rdbForDay.Size = new System.Drawing.Size(112, 20);
            this.rdbForDay.TabIndex = 15;
            this.rdbForDay.TabStop = true;
            this.rdbForDay.Text = "History for day";
            this.rdbForDay.UseVisualStyleBackColor = true;
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowHistory.Location = new System.Drawing.Point(106, 277);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(75, 23);
            this.btnShowHistory.TabIndex = 16;
            this.btnShowHistory.Text = "Show";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 336);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.rdbForAllTime);
            this.Controls.Add(this.rdbForDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbHistory);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbForAllTime;
        private System.Windows.Forms.RadioButton rdbForDay;
        private System.Windows.Forms.Button btnShowHistory;
    }
}