namespace TestTask_WF
{
    partial class NewProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.btnCreateProj = new System.Windows.Forms.Button();
            this.dtpProjStart = new System.Windows.Forms.DateTimePicker();
            this.dtpProjEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project end";
            // 
            // txbProjectName
            // 
            this.txbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbProjectName.Location = new System.Drawing.Point(159, 42);
            this.txbProjectName.Name = "txbProjectName";
            this.txbProjectName.Size = new System.Drawing.Size(139, 22);
            this.txbProjectName.TabIndex = 1;
            // 
            // btnCreateProj
            // 
            this.btnCreateProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateProj.Location = new System.Drawing.Point(109, 137);
            this.btnCreateProj.Name = "btnCreateProj";
            this.btnCreateProj.Size = new System.Drawing.Size(75, 23);
            this.btnCreateProj.TabIndex = 2;
            this.btnCreateProj.Text = "Create";
            this.btnCreateProj.UseVisualStyleBackColor = true;
            this.btnCreateProj.Click += new System.EventHandler(this.btnCreateProj_Click);
            // 
            // dtpProjStart
            // 
            this.dtpProjStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpProjStart.Location = new System.Drawing.Point(159, 71);
            this.dtpProjStart.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpProjStart.Name = "dtpProjStart";
            this.dtpProjStart.Size = new System.Drawing.Size(139, 22);
            this.dtpProjStart.TabIndex = 3;
            // 
            // dtpProjEnd
            // 
            this.dtpProjEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpProjEnd.Location = new System.Drawing.Point(159, 99);
            this.dtpProjEnd.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpProjEnd.Name = "dtpProjEnd";
            this.dtpProjEnd.Size = new System.Drawing.Size(139, 22);
            this.dtpProjEnd.TabIndex = 3;
            this.dtpProjEnd.Value = new System.DateTime(2020, 8, 16, 0, 0, 0, 0);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 197);
            this.Controls.Add(this.dtpProjEnd);
            this.Controls.Add(this.dtpProjStart);
            this.Controls.Add(this.btnCreateProj);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProject";
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProjectName;
        private System.Windows.Forms.Button btnCreateProj;
        private System.Windows.Forms.DateTimePicker dtpProjStart;
        private System.Windows.Forms.DateTimePicker dtpProjEnd;
    }
}