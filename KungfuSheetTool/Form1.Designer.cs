namespace KungfuSheetTool
{
    partial class Form1
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
            this.lbName = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lbCheckedIn = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lbPaymentDate = new System.Windows.Forms.Label();
            this.lbTotalClasses = new System.Windows.Forms.Label();
            this.lbTotalClassResult = new System.Windows.Forms.Label();
            this.lbClassSoFar = new System.Windows.Forms.Label();
            this.lbClassSoFarResult = new System.Windows.Forms.Label();
            this.lbClassPerWeek = new System.Windows.Forms.Label();
            this.lbTimesByWeek = new System.Windows.Forms.Label();
            this.lbPaymentPlan = new System.Windows.Forms.Label();
            this.lbMonths = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(41, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(98, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Student Name";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(182, 52);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(189, 21);
            this.cbName.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(421, 50);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lbCheckedIn
            // 
            this.lbCheckedIn.AutoSize = true;
            this.lbCheckedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckedIn.Location = new System.Drawing.Point(41, 125);
            this.lbCheckedIn.Name = "lbCheckedIn";
            this.lbCheckedIn.Size = new System.Drawing.Size(127, 17);
            this.lbCheckedIn.TabIndex = 3;
            this.lbCheckedIn.Text = "Latest checked in: ";
            this.lbCheckedIn.Visible = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(179, 125);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(46, 17);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "label3";
            this.lbTime.Visible = false;
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.Location = new System.Drawing.Point(41, 185);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(114, 17);
            this.lbPayment.TabIndex = 5;
            this.lbPayment.Text = "Next payment at:";
            this.lbPayment.Visible = false;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(421, 93);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 6;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lbPaymentDate
            // 
            this.lbPaymentDate.AutoSize = true;
            this.lbPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentDate.Location = new System.Drawing.Point(179, 185);
            this.lbPaymentDate.Name = "lbPaymentDate";
            this.lbPaymentDate.Size = new System.Drawing.Size(46, 17);
            this.lbPaymentDate.TabIndex = 7;
            this.lbPaymentDate.Text = "label5";
            this.lbPaymentDate.Visible = false;
            // 
            // lbTotalClasses
            // 
            this.lbTotalClasses.AutoSize = true;
            this.lbTotalClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalClasses.Location = new System.Drawing.Point(41, 329);
            this.lbTotalClasses.Name = "lbTotalClasses";
            this.lbTotalClasses.Size = new System.Drawing.Size(111, 17);
            this.lbTotalClasses.TabIndex = 8;
            this.lbTotalClasses.Text = "Allowed classes:";
            this.lbTotalClasses.Visible = false;
            // 
            // lbTotalClassResult
            // 
            this.lbTotalClassResult.AutoSize = true;
            this.lbTotalClassResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalClassResult.Location = new System.Drawing.Point(179, 329);
            this.lbTotalClassResult.Name = "lbTotalClassResult";
            this.lbTotalClassResult.Size = new System.Drawing.Size(46, 17);
            this.lbTotalClassResult.TabIndex = 9;
            this.lbTotalClassResult.Text = "label7";
            this.lbTotalClassResult.Visible = false;
            // 
            // lbClassSoFar
            // 
            this.lbClassSoFar.AutoSize = true;
            this.lbClassSoFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassSoFar.Location = new System.Drawing.Point(41, 376);
            this.lbClassSoFar.Name = "lbClassSoFar";
            this.lbClassSoFar.Size = new System.Drawing.Size(129, 17);
            this.lbClassSoFar.TabIndex = 10;
            this.lbClassSoFar.Text = "Classes up to date:";
            this.lbClassSoFar.Visible = false;
            // 
            // lbClassSoFarResult
            // 
            this.lbClassSoFarResult.AutoSize = true;
            this.lbClassSoFarResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassSoFarResult.Location = new System.Drawing.Point(179, 376);
            this.lbClassSoFarResult.Name = "lbClassSoFarResult";
            this.lbClassSoFarResult.Size = new System.Drawing.Size(46, 17);
            this.lbClassSoFarResult.TabIndex = 11;
            this.lbClassSoFarResult.Text = "label9";
            this.lbClassSoFarResult.Visible = false;
            // 
            // lbClassPerWeek
            // 
            this.lbClassPerWeek.AutoSize = true;
            this.lbClassPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassPerWeek.Location = new System.Drawing.Point(41, 230);
            this.lbClassPerWeek.Name = "lbClassPerWeek";
            this.lbClassPerWeek.Size = new System.Drawing.Size(123, 17);
            this.lbClassPerWeek.TabIndex = 12;
            this.lbClassPerWeek.Text = "Classed per week:";
            this.lbClassPerWeek.Visible = false;
            // 
            // lbTimesByWeek
            // 
            this.lbTimesByWeek.AutoSize = true;
            this.lbTimesByWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimesByWeek.Location = new System.Drawing.Point(179, 230);
            this.lbTimesByWeek.Name = "lbTimesByWeek";
            this.lbTimesByWeek.Size = new System.Drawing.Size(54, 17);
            this.lbTimesByWeek.TabIndex = 13;
            this.lbTimesByWeek.Text = "label11";
            this.lbTimesByWeek.Visible = false;
            // 
            // lbPaymentPlan
            // 
            this.lbPaymentPlan.AutoSize = true;
            this.lbPaymentPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentPlan.Location = new System.Drawing.Point(41, 278);
            this.lbPaymentPlan.Name = "lbPaymentPlan";
            this.lbPaymentPlan.Size = new System.Drawing.Size(98, 17);
            this.lbPaymentPlan.TabIndex = 14;
            this.lbPaymentPlan.Text = "Payment plan:";
            this.lbPaymentPlan.Visible = false;
            // 
            // lbMonths
            // 
            this.lbMonths.AutoSize = true;
            this.lbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonths.Location = new System.Drawing.Point(179, 278);
            this.lbMonths.Name = "lbMonths";
            this.lbMonths.Size = new System.Drawing.Size(54, 17);
            this.lbMonths.TabIndex = 15;
            this.lbMonths.Text = "label13";
            this.lbMonths.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 526);
            this.Controls.Add(this.lbMonths);
            this.Controls.Add(this.lbPaymentPlan);
            this.Controls.Add(this.lbTimesByWeek);
            this.Controls.Add(this.lbClassPerWeek);
            this.Controls.Add(this.lbClassSoFarResult);
            this.Controls.Add(this.lbClassSoFar);
            this.Controls.Add(this.lbTotalClassResult);
            this.Controls.Add(this.lbTotalClasses);
            this.Controls.Add(this.lbPaymentDate);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbCheckedIn);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Soaring Eagle Kungfu Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lbCheckedIn;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lbPaymentDate;
        private System.Windows.Forms.Label lbTotalClasses;
        private System.Windows.Forms.Label lbTotalClassResult;
        private System.Windows.Forms.Label lbClassSoFar;
        private System.Windows.Forms.Label lbClassSoFarResult;
        private System.Windows.Forms.Label lbClassPerWeek;
        private System.Windows.Forms.Label lbTimesByWeek;
        private System.Windows.Forms.Label lbPaymentPlan;
        private System.Windows.Forms.Label lbMonths;
    }
}

