
namespace FitnessTrackerProject
{
    partial class SetGoal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtgoaldescription = new System.Windows.Forms.TextBox();
            this.txttgtcalories = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtgoalid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtgoaldescription);
            this.panel1.Controls.Add(this.txttgtcalories);
            this.panel1.Controls.Add(this.txtuserid);
            this.panel1.Controls.Add(this.txtgoalid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 654);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(453, 28);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.ForeColor = System.Drawing.Color.Yellow;
            this.btnsave.Location = new System.Drawing.Point(566, 564);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(131, 44);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtgoaldescription
            // 
            this.txtgoaldescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgoaldescription.Location = new System.Drawing.Point(244, 451);
            this.txtgoaldescription.Multiline = true;
            this.txtgoaldescription.Name = "txtgoaldescription";
            this.txtgoaldescription.Size = new System.Drawing.Size(453, 107);
            this.txtgoaldescription.TabIndex = 7;
            // 
            // txttgtcalories
            // 
            this.txttgtcalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttgtcalories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttgtcalories.Location = new System.Drawing.Point(244, 355);
            this.txttgtcalories.Name = "txttgtcalories";
            this.txttgtcalories.Size = new System.Drawing.Size(453, 30);
            this.txttgtcalories.TabIndex = 6;
            // 
            // txtuserid
            // 
            this.txtuserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuserid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(244, 256);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(453, 30);
            this.txtuserid.TabIndex = 5;
            // 
            // txtgoalid
            // 
            this.txtgoalid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgoalid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgoalid.Location = new System.Drawing.Point(244, 161);
            this.txtgoalid.Name = "txtgoalid";
            this.txtgoalid.Size = new System.Drawing.Size(453, 30);
            this.txtgoalid.TabIndex = 4;
            //this.txtgoalid.TextChanged += new System.EventHandler(this.txtgoalid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goal Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "GoalID";
            // 
            // SetGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 654);
            this.Controls.Add(this.panel1);
            this.Name = "SetGoal";
            this.Text = "SetGoals";
            this.Load += new System.EventHandler(this.SetGoal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtgoaldescription;
        private System.Windows.Forms.TextBox txttgtcalories;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtgoalid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}