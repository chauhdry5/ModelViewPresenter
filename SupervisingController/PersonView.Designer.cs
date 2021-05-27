namespace SupervisingController
{
    partial class PersonView
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
            this.btnLoadPersonInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadPersonInfo
            // 
            this.btnLoadPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoadPersonInfo.Location = new System.Drawing.Point(504, 130);
            this.btnLoadPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPersonInfo.Name = "btnLoadPersonInfo";
            this.btnLoadPersonInfo.Size = new System.Drawing.Size(190, 40);
            this.btnLoadPersonInfo.TabIndex = 8;
            this.btnLoadPersonInfo.Text = "Load Person Info";
            this.btnLoadPersonInfo.UseVisualStyleBackColor = true;
            this.btnLoadPersonInfo.Click += new System.EventHandler(this.BtnLoadPersonInfoClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new System.Drawing.Point(151, 77);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(543, 30);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(151, 20);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(543, 30);
            this.txtFirstName.TabIndex = 5;
            // 
            // PersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 194);
            this.Controls.Add(this.btnLoadPersonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "PersonView";
            this.Text = "Person - Supervising Controller";
            this.Load += new System.EventHandler(this.PersonView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPersonInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}

