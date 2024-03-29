﻿namespace Threading.AsyncDelegate
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
            this.btnResuturnTask = new System.Windows.Forms.Button();
            this.txtSumOfNumbersList = new System.Windows.Forms.TextBox();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnPLinq = new System.Windows.Forms.Button();
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
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // btnResuturnTask
            // 
            this.btnResuturnTask.Location = new System.Drawing.Point(398, 12);
            this.btnResuturnTask.Name = "btnResuturnTask";
            this.btnResuturnTask.Size = new System.Drawing.Size(110, 30);
            this.btnResuturnTask.TabIndex = 5;
            this.btnResuturnTask.Text = "Start Return Task";
            this.btnResuturnTask.UseVisualStyleBackColor = true;
            this.btnResuturnTask.Click += new System.EventHandler(this.btnResuturnTask_Click);
            // 
            // txtSumOfNumbersList
            // 
            this.txtSumOfNumbersList.Location = new System.Drawing.Point(398, 48);
            this.txtSumOfNumbersList.Multiline = true;
            this.txtSumOfNumbersList.Name = "txtSumOfNumbersList";
            this.txtSumOfNumbersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSumOfNumbersList.Size = new System.Drawing.Size(361, 390);
            this.txtSumOfNumbersList.TabIndex = 6;
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.Location = new System.Drawing.Point(514, 12);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(108, 30);
            this.btnCancelTask.TabIndex = 5;
            this.btnCancelTask.Text = "Stop Task";
            this.btnCancelTask.UseVisualStyleBackColor = true;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // btnPLinq
            // 
            this.btnPLinq.Location = new System.Drawing.Point(240, 12);
            this.btnPLinq.Name = "btnPLinq";
            this.btnPLinq.Size = new System.Drawing.Size(108, 30);
            this.btnPLinq.TabIndex = 5;
            this.btnPLinq.Text = "PLinQ";
            this.btnPLinq.UseVisualStyleBackColor = true;
            this.btnPLinq.Click += new System.EventHandler(this.btnPLinq_Click);
            // 
            // TaskParallelLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSumOfNumbersList);
            this.Controls.Add(this.txtTaskNumbers);
            this.Controls.Add(this.btnCancelTask);
            this.Controls.Add(this.btnPLinq);
            this.Controls.Add(this.btnStopTask);
            this.Controls.Add(this.btnResuturnTask);
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
        private System.Windows.Forms.Button btnResuturnTask;
        private System.Windows.Forms.TextBox txtSumOfNumbersList;
        private System.Windows.Forms.Button btnCancelTask;
        private System.Windows.Forms.Button btnPLinq;
    }
}