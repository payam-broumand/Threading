namespace Threading.AsyncDelegate
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
            this.tnStartProcess = new System.Windows.Forms.Button();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.txtProcessList = new System.Windows.Forms.TextBox();
            this.btnStartSecondProcess = new System.Windows.Forms.Button();
            this.btnStopSecondProcess = new System.Windows.Forms.Button();
            this.txtSeondProcessDataList = new System.Windows.Forms.TextBox();
            this.txtSumNumbersList = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tnStartProcess
            // 
            this.tnStartProcess.Location = new System.Drawing.Point(12, 12);
            this.tnStartProcess.Name = "tnStartProcess";
            this.tnStartProcess.Size = new System.Drawing.Size(101, 37);
            this.tnStartProcess.TabIndex = 0;
            this.tnStartProcess.Text = "Start Process";
            this.tnStartProcess.UseVisualStyleBackColor = true;
            this.tnStartProcess.Click += new System.EventHandler(this.tnStartProcess_Click);
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Location = new System.Drawing.Point(119, 12);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(101, 37);
            this.btnEndProcess.TabIndex = 0;
            this.btnEndProcess.Text = "Stop Process";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // txtProcessList
            // 
            this.txtProcessList.Location = new System.Drawing.Point(12, 55);
            this.txtProcessList.Multiline = true;
            this.txtProcessList.Name = "txtProcessList";
            this.txtProcessList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessList.Size = new System.Drawing.Size(254, 383);
            this.txtProcessList.TabIndex = 1;
            // 
            // btnStartSecondProcess
            // 
            this.btnStartSecondProcess.Location = new System.Drawing.Point(286, 12);
            this.btnStartSecondProcess.Name = "btnStartSecondProcess";
            this.btnStartSecondProcess.Size = new System.Drawing.Size(101, 37);
            this.btnStartSecondProcess.TabIndex = 0;
            this.btnStartSecondProcess.Text = "Start Second Process";
            this.btnStartSecondProcess.UseVisualStyleBackColor = true;
            this.btnStartSecondProcess.Click += new System.EventHandler(this.btnStartSecondProcess_Click);
            // 
            // btnStopSecondProcess
            // 
            this.btnStopSecondProcess.Location = new System.Drawing.Point(393, 12);
            this.btnStopSecondProcess.Name = "btnStopSecondProcess";
            this.btnStopSecondProcess.Size = new System.Drawing.Size(101, 37);
            this.btnStopSecondProcess.TabIndex = 0;
            this.btnStopSecondProcess.Text = "Stop Second Process";
            this.btnStopSecondProcess.UseVisualStyleBackColor = true;
            this.btnStopSecondProcess.Click += new System.EventHandler(this.btnStopSecondProcess_Click);
            // 
            // txtSeondProcessDataList
            // 
            this.txtSeondProcessDataList.Location = new System.Drawing.Point(286, 55);
            this.txtSeondProcessDataList.Multiline = true;
            this.txtSeondProcessDataList.Name = "txtSeondProcessDataList";
            this.txtSeondProcessDataList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSeondProcessDataList.Size = new System.Drawing.Size(254, 383);
            this.txtSeondProcessDataList.TabIndex = 1;
            // 
            // txtSumNumbersList
            // 
            this.txtSumNumbersList.Location = new System.Drawing.Point(563, 55);
            this.txtSumNumbersList.Multiline = true;
            this.txtSumNumbersList.Name = "txtSumNumbersList";
            this.txtSumNumbersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSumNumbersList.Size = new System.Drawing.Size(254, 383);
            this.txtSumNumbersList.TabIndex = 1;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(563, 12);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(101, 37);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum of Numbers";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.txtSumNumbersList);
            this.Controls.Add(this.txtSeondProcessDataList);
            this.Controls.Add(this.txtProcessList);
            this.Controls.Add(this.btnStopSecondProcess);
            this.Controls.Add(this.btnEndProcess);
            this.Controls.Add(this.btnStartSecondProcess);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.tnStartProcess);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tnStartProcess;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.TextBox txtProcessList;
        private System.Windows.Forms.Button btnStartSecondProcess;
        private System.Windows.Forms.Button btnStopSecondProcess;
        private System.Windows.Forms.TextBox txtSeondProcessDataList;
        private System.Windows.Forms.TextBox txtSumNumbersList;
        private System.Windows.Forms.Button btnSum;
    }
}

