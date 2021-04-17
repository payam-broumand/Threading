namespace Threading.AsyncDelegate
{
    partial class TaskParallelLibraryForm
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
            this.txtTaskNumbers = new System.Windows.Forms.TextBox();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaskNumbers
            // 
            this.txtTaskNumbers.Location = new System.Drawing.Point(12, 48);
            this.txtTaskNumbers.Multiline = true;
            this.txtTaskNumbers.Name = "txtTaskNumbers";
            this.txtTaskNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaskNumbers.Size = new System.Drawing.Size(361, 390);
            this.txtTaskNumbers.TabIndex = 6;
            // 
            // btnStartTask
            // 
            this.btnStartTask.Location = new System.Drawing.Point(12, 12);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(108, 30);
            this.btnStartTask.TabIndex = 5;
            this.btnStartTask.Text = "Start Task";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.Location = new System.Drawing.Point(126, 12);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(108, 30);
            this.btnStopTask.TabIndex = 5;
            this.btnStopTask.Text = "Stop Task";
            this.btnStopTask.UseVisualStyleBackColor = true;
            // 
            // TaskParallelLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTaskNumbers);
            this.Controls.Add(this.btnStopTask);
            this.Controls.Add(this.btnStartTask);
            this.Name = "TaskParallelLibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Parallel Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskNumbers;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnStopTask;
    }
}