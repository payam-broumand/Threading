namespace Threading.AsyncDelegate
{
    partial class AsyncForm
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
            this.listProcess = new System.Windows.Forms.ListBox();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listProcess
            // 
            this.listProcess.FormattingEnabled = true;
            this.listProcess.Location = new System.Drawing.Point(18, 56);
            this.listProcess.Name = "listProcess";
            this.listProcess.Size = new System.Drawing.Size(338, 290);
            this.listProcess.TabIndex = 0;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(120, 12);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(109, 38);
            this.btnStartProcess.TabIndex = 1;
            this.btnStartProcess.Text = "Start Process";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMessage.Location = new System.Drawing.Point(18, 366);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(338, 36);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Process List Completed";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AsyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 418);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.listProcess);
            this.Name = "AsyncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProcess;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Label lblMessage;
    }
}