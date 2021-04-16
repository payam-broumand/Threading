namespace Threading.AsyncDelegate
{
    partial class ThreadForm
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
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.btnStopProcess = new System.Windows.Forms.Button();
            this.txtProcessList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(12, 12);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(108, 30);
            this.btnStartProcess.TabIndex = 0;
            this.btnStartProcess.Text = "Start Process";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // btnStopProcess
            // 
            this.btnStopProcess.Location = new System.Drawing.Point(126, 12);
            this.btnStopProcess.Name = "btnStopProcess";
            this.btnStopProcess.Size = new System.Drawing.Size(108, 30);
            this.btnStopProcess.TabIndex = 0;
            this.btnStopProcess.Text = "Stop Process";
            this.btnStopProcess.UseVisualStyleBackColor = true;
            // 
            // txtProcessList
            // 
            this.txtProcessList.Location = new System.Drawing.Point(12, 48);
            this.txtProcessList.Multiline = true;
            this.txtProcessList.Name = "txtProcessList";
            this.txtProcessList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcessList.Size = new System.Drawing.Size(361, 390);
            this.txtProcessList.TabIndex = 1;
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.txtProcessList);
            this.Controls.Add(this.btnStopProcess);
            this.Controls.Add(this.btnStartProcess);
            this.Name = "ThreadForm";
            this.Text = "ThreadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Button btnStopProcess;
        private System.Windows.Forms.TextBox txtProcessList;
    }
}